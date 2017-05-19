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

            _array[row, column] = value;
        }

        public string Solve()
        {
            var solution = 0;
            var rowNumber = 0;
            var columnNumber = 0;

            var rowMaxHeight = _array.GetLength(0);     // row dimensions
            var columnMaxLength = _array.GetLength(1);  // column dimensions

            while (columnNumber <= columnMaxLength - 1)
            {
                var tempRowNumber = rowNumber + 1;
                if(tempRowNumber > rowMaxHeight)
                {
                    tempRowNumber = 0;
                }
                var upperValue = _array[tempRowNumber, columnNumber];

                var horizontalValue = _array[rowNumber, columnNumber];

                var tempRowNumber2 = rowNumber - 1;
                if (tempRowNumber2 < 0)
                {
                    tempRowNumber2 = rowMaxHeight - 1;
                }
                var lowerValue = _array[tempRowNumber2, columnNumber];

                var direction = GetLeastCost(upperValue, horizontalValue, lowerValue);
                if (direction == "upper")
                {
                    rowNumber = upperValue;
                    solution = solution + _array[tempRowNumber, columnNumber];
                }

                if (direction == "horizontal")
                {
                    solution = solution + _array[rowNumber, columnNumber];
                }

                if (direction == "lower")
                {
                    rowNumber = lowerValue;
                    solution = solution + _array[tempRowNumber2, columnNumber];
                }

                columnNumber++;
            }

            return solution.ToString();
        }

        private string GetLeastCost(int upper, int horizontal, int lower)
        {
            if (upper < horizontal)
            {
                if (upper < lower)
                {
                    return "upper";
                }
            }
            else if (horizontal < upper)
            {
                if(horizontal < lower)
                {
                    return "horizontal";
                }
            }

            return "lower";
        }
    }
}