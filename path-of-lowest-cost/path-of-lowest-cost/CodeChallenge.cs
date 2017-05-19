using System;

namespace path_of_lowest_cost
{
    public class CodeChallenge
    {
        private readonly int _rows;
        private readonly int _columns;
        private int[,] _array;

        public CodeChallenge(int rows, int columns)
        {
            if (rows <= 0)
            {
                throw new ArgumentOutOfRangeException("you must have at least 1 row");
            }

            if (columns <= 4)
            {
                throw new ArgumentOutOfRangeException("columns", "you must have at least 5 columns");
            }

            _rows = rows;
            _columns = columns;
            _array = new int[_rows, _columns];
        }

        public int[,] GetArray()
        {
            return _array;
        }

        public void AddValueToArray(int column, int row, int value)
        {
            if (row < 0)
            {
                throw new IndexOutOfRangeException("row must not be a negative number");
            }

            if (column < 0)
            {
                throw new IndexOutOfRangeException("column must not be a negative number");
            }

            _array[column, row] = value;
        }


    }
}
