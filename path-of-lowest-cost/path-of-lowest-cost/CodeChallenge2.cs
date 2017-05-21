using System;
using System.Collections.Generic;

namespace path_of_lowest_cost
{
    public class CodeChallenge2
    {
        private readonly int[,] _grid;
        private string _isSolved;
        private int _solutionTotal;
        private List<int> _selectedColumns;

        public CodeChallenge2(int[,] grid)
        {
            _grid = grid;
            _isSolved = "Yes";
            _solutionTotal = 0;
            _selectedColumns = new List<int>();
        }

        public Tuple<string, int, List<int>> SolveChallenge()
        {
            var row = 0;

            for(int i = 0; i < _grid.GetLength(1); i++)
            {
                _solutionTotal += _grid[row, i];
                _selectedColumns.Add(row + 1);

                if (_solutionTotal > 50)
                {
                    _isSolved = "No";
                    break;
                }
            }

            return new Tuple<string, int, List<int>>(_isSolved, _solutionTotal, _selectedColumns);
        }
    }
}
