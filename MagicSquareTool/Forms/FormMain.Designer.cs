
namespace MagicSquareTool.Forms
{
    partial class FormMain
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.Pic_Board = new System.Windows.Forms.PictureBox();
            this.Btn_CreateMagicSquare = new System.Windows.Forms.Button();
            this.Lbl_GridSize = new System.Windows.Forms.Label();
            this.Txt_GridSize = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Board)).BeginInit();
            this.SuspendLayout();
            // 
            // Pic_Board
            // 
            this.Pic_Board.Location = new System.Drawing.Point(127, 35);
            this.Pic_Board.Name = "Pic_Board";
            this.Pic_Board.Size = new System.Drawing.Size(312, 291);
            this.Pic_Board.TabIndex = 0;
            this.Pic_Board.TabStop = false;
            // 
            // Btn_CreateMagicSquare
            // 
            this.Btn_CreateMagicSquare.Location = new System.Drawing.Point(12, 66);
            this.Btn_CreateMagicSquare.Name = "Btn_CreateMagicSquare";
            this.Btn_CreateMagicSquare.Size = new System.Drawing.Size(105, 44);
            this.Btn_CreateMagicSquare.TabIndex = 1;
            this.Btn_CreateMagicSquare.Text = "魔法陣を作成";
            this.Btn_CreateMagicSquare.UseVisualStyleBackColor = true;
            this.Btn_CreateMagicSquare.Click += new System.EventHandler(this.Btn_CreateMagicSquare_Click);
            // 
            // Lbl_GridSize
            // 
            this.Lbl_GridSize.AutoSize = true;
            this.Lbl_GridSize.Location = new System.Drawing.Point(3, 44);
            this.Lbl_GridSize.Name = "Lbl_GridSize";
            this.Lbl_GridSize.Size = new System.Drawing.Size(65, 12);
            this.Lbl_GridSize.TabIndex = 2;
            this.Lbl_GridSize.Text = "・一辺の長さ";
            // 
            // Txt_GridSize
            // 
            this.Txt_GridSize.Location = new System.Drawing.Point(74, 41);
            this.Txt_GridSize.Name = "Txt_GridSize";
            this.Txt_GridSize.Size = new System.Drawing.Size(36, 19);
            this.Txt_GridSize.TabIndex = 3;
            this.Txt_GridSize.Text = "3";
            this.Txt_GridSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 338);
            this.Controls.Add(this.Txt_GridSize);
            this.Controls.Add(this.Lbl_GridSize);
            this.Controls.Add(this.Btn_CreateMagicSquare);
            this.Controls.Add(this.Pic_Board);
            this.Name = "FormMain";
            this.Text = "MagicSquareTool";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Pic_Board)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Pic_Board;
        private System.Windows.Forms.Button Btn_CreateMagicSquare;
        private System.Windows.Forms.Label Lbl_GridSize;
        private System.Windows.Forms.TextBox Txt_GridSize;
    }
}

