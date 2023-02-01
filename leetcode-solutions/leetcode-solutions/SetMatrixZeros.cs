using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace leetcode_solutions
{
    internal class SetMatrixZeros
    {
        public void SetZeroes(int[][] matrix)
        {
            var rowIndexes = Enumerable.Range(0, matrix.Length).ToList();
            var columnIndexes = Enumerable.Range(0, matrix[0].Length).ToList();


            SetZeroesInternal(matrix, 0, 0, rowIndexes, columnIndexes);

            for (int i = 0; i <matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length; j++)
                {
                    if (!rowIndexes.Contains(i) || !columnIndexes.Contains(j))
                    {
                        matrix[i][j] = 0;
                    }
                }
            }
        }

        private void SetZeroesInternal(int[][] matrix, int row, int col, List<int> rowIndexes, List<int> columnIndexes)
        {
            for (var j = col; j < matrix[0].Length; j++)
            {
                var item = matrix[row][j];

                if (item == 0)
                {
                    rowIndexes.Remove(row);
                    columnIndexes.Remove(j);
                }
            }

            for (var i = row; i < matrix.Length; i++)
            {
                var item = matrix[i][col];

                if (item == 0)
                {
                    rowIndexes.Remove(i);
                    columnIndexes.Remove(col);
                }
            }

            row++;
            col++;
            if (row < matrix.Length && col < matrix[0].Length)
            {
                SetZeroesInternal(matrix, row, col, rowIndexes, columnIndexes);
            }
        }
    }
}
