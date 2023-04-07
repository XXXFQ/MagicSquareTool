using System;
using System.Drawing;
using System.Windows.Forms;

using MagicSquareTool.Square;
using MagicSquareTool.Properties;

namespace MagicSquareTool.Forms
{
    public partial class FormMain : Form
    {
        private MagicSquare magicSquare = null;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // マス目の一辺の長さ
            int gridSize = 3;

            magicSquare = new MagicSquare(gridSize);
            DrawGrid(gridSize);
        }

        /// <summary>
        /// 魔方陣を作成ボタンを押したときの動作
        /// </summary>
        private void Btn_CreateMagicSquare_Click(object sender, EventArgs e)
        {
            int gridSize = Convert.ToInt32(Txt_GridSize.Text);

            if (gridSize <= 0)
            {
                MessageBox.Show(Resources.RetypeNumberMessage, Resources.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            magicSquare = new MagicSquare(gridSize);
            magicSquare.Setup();
            DrawGrid(magicSquare.GridSize);
        }

        /// <summary>
        /// マス目を描画する
        /// </summary>
        /// <param name="gridSize">マス目の一辺の長さ</param>
        private void DrawGrid(int gridSize)
        {
            int cellSize = 50; // 1つのマスの一辺の長さ
            int gridWidth = cellSize * gridSize; // マス目の幅
            int gridHeight = cellSize * gridSize; // マス目の高さ
            int margin = 10; // マージン

            Pic_Board.Width = gridWidth + margin * 2; // ピクチャーボックスの幅を設定する
            Pic_Board.Height = gridHeight + margin * 2; // ピクチャーボックスの高さを設定する

            // PictureBoxコントロールにグラフィックスオブジェクトを作成する
            Bitmap bmp = new Bitmap(gridSize * cellSize + 2 * margin, gridSize * cellSize + 2 * margin);
            Graphics g = Graphics.FromImage(bmp);

            // 白い背景を描画する
            g.Clear(Color.White);

            // 縦横の線を描画する
            Pen pen = new Pen(Color.Black, 1);
            for (int i = 0; i <= gridSize; i++)
            {
                int x = i * cellSize + margin;
                g.DrawLine(pen, x, margin, x, gridSize * cellSize + margin); // 縦線
                g.DrawLine(pen, margin, x, gridSize * cellSize + margin, x); // 横線
            }

            Font font = new Font("Arial", 16);

            // マス目の中心に番号を描画する
            for (int i = 0; i < gridSize; i++)
            {
                for (int j = 0; j < gridSize; j++)
                {
                    int x = i * cellSize + cellSize / 2 + margin;
                    int y = j * cellSize + cellSize / 2 + margin;
                    string number = magicSquare.Squares[j, i].ToString(); // 1から始まる番号
                    SizeF size = g.MeasureString(number, font); // 描画する番号のサイズを取得する
                    PointF pos = new PointF(x - size.Width / 2, y - size.Height / 2); // 中央に揃えるための位置を計算する
                    g.DrawString(number, font, Brushes.Black, pos); // 番号を描画する
                }
            }

            // PictureBoxコントロールに描画する
            Pic_Board.Image = bmp;
        }

        private void Txt_GridSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            //バックスペースが押された時は有効（Deleteキーも有効）
            if (e.KeyChar == '\b') return;

            //数値0～9以外が押された時はイベントをキャンセルする
            if (e.KeyChar < '0' || '9' < e.KeyChar)
            {
                e.Handled = true;
            }
        }
    }
}