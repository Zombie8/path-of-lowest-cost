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
                throw new ArgumentOutOfRangeException("Cannot initialize CodeChallenge with negative or zero rows");
            }

            if (columns <= 0)
            {
                throw new ArgumentOutOfRangeException("Cannot initialize CodeChallenge with negative or zero columns");
            }

            _rows = rows;
            _columns = columns;
            _array = new int[_columns, _rows];
        }

        public int[,] GetArray()
        {
            return _array;
        }

        public void AddValueToArray(int row, int column, int value)
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
