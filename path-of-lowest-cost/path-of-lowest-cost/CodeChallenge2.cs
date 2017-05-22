﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace path_of_lowest_cost
{
    public class CodeChallenge2
    {
        private readonly int[,] _grid;
        private List<Attempt> _attempts;

        public CodeChallenge2(int[,] grid)
        {
            _grid = grid;
            _attempts = new List<Attempt>();
        }

        public Attempt SolveChallenge()
        {
            // iterate through each row in grid
            for (int i = 0; i < _grid.GetLength(0); i++)
            {
                attemptChallenge(i);
            }

            // determine which iteration was the least cost
            var leastCostAttempt = _attempts.OrderBy(x => x.solutionTotal).First();

            // return least cost row
            return leastCostAttempt;
        }

        private void attemptChallenge(int row)
        {
            var newAttempt = new Attempt();
            var workingRow = row;

            for (int columnIndex = 0; columnIndex < _grid.GetLength(1); columnIndex++)
            {
                workingRow  = nextMove(workingRow, columnIndex);

                newAttempt.solutionTotal += _grid[workingRow, columnIndex];
                newAttempt.selectedMatrixPoints.Add(workingRow + 1);

                if (newAttempt.solutionTotal > 50)
                {
                    newAttempt.isSolved = "No";
                    break;
                }
            }

            _attempts.Add(newAttempt);
        }

        private int nextMove(int row, int column)
        {
            var columnHeight = _grid.GetLength(0);
            var didUpValFlip = false;
            var didDownValFlip = false;

            int upVal;
            if (row + 1 >= columnHeight)
            {
                upVal = _grid[0, column];
                didUpValFlip = true;
            }
            else
            {
                upVal = _grid[row + 1, column];
            }

            var rightVal = _grid[row, column];

            int downVal;
            if(row - 1 <= 0)
            {
                downVal = _grid[columnHeight - 1, column];
                didDownValFlip = true;
            }
            else
            {
                downVal = _grid[row - 1, column];
            }

            if (upVal < rightVal && upVal < downVal)
            {
                if (didUpValFlip)
                {
                    return 0;
                }
                return row + 1;
            }
            else if (rightVal < downVal)
            {
                return row;
            }
            else
            {
                if (didDownValFlip)
                {
                    return columnHeight - 1;
                }
                return row - 1;
            }

        }
    }

    public class Attempt
    {
        public string isSolved { get; set; }
        public int solutionTotal { get; set; }
        public List<int> selectedMatrixPoints { get; set; }

        public Attempt()
        {
            isSolved = "Yes";
            selectedMatrixPoints = new List<int>();
        }
    }
}
