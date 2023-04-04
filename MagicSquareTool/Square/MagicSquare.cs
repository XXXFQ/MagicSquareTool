using System;

namespace MagicSquareTool.Square
{
    class MagicSquare
    {
        public MagicSquare(int _gridSize)
        {
            this.Squares = new int[_gridSize, _gridSize];
            Resetting();
        }

        /// <summary>
        /// 方陣を初期化する
        /// </summary>
        private void Resetting()
        {
            for (int yIndex = 0; yIndex < this.GridSize; yIndex++)
            {
                for (int xIndex = 0; xIndex < this.GridSize; xIndex++)
                {
                    this.Squares[yIndex, xIndex] = 0;
                }
            }
        }

        /// <summary>
        /// 魔方陣を作成する
        /// </summary>
        public void Setup()
        {
            if (this.Squares[0, 0] != 0) Resetting();

            if (this.GridSize % 2 != 0) {
                Setup_odd();
            } else {
                Setup_even();
            }
        }

        /// <summary>
        /// 奇数×奇数の魔方陣を作成する
        /// </summary>
        private void Setup_odd()
        {
            int yIndex = this.GridSize - 1;
            int xIndex = (this.GridSize + 1) / 2 - 1;
            int value = 1;
            this.Squares[yIndex, xIndex] = value;

            while (this.Squares[yIndex, xIndex] < Math.Pow(this.GridSize, 2))
            {
                int yBackUp = yIndex++;
                int xBackUp = xIndex++;

                // 現在位置の右下のマスが空白かどうか確認
                if (yIndex >= this.GridSize)
                {
                    // 最下行の下は最上行
                    yIndex = 0;
                }
                if (xIndex >= this.GridSize)
                {
                    // 最右列の右は最左列
                    xIndex = 0;
                }

                // 確認したマスが空白でない場合は，現在位置の上のマスを新しい現在位置とする
                if (this.Squares[yIndex, xIndex] != 0)
                {
                    yIndex = yBackUp - 1;
                    xIndex = xBackUp;
                }

                // 数を一つ増やし，現在位置にその数を配置
                this.Squares[yIndex, xIndex] = ++value;
            }
        }

        /// <summary>
        /// 偶数×偶数の魔方陣を作成する
        /// </summary>
        private void Setup_even()
        {

        }

        public int[,] Squares { get; }

        public int GridSize => Squares.GetLength(0);
    }
}
