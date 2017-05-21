using System;
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

            for (int i = 0; i < _grid.GetLength(1); i++)
            {
                newAttempt.solutionTotal += _grid[row, i];
                newAttempt.selectedMatrixPoints.Add(row + 1);

                if (newAttempt.solutionTotal > 50)
                {
                    newAttempt.isSolved = "No";
                    break;
                }
            }

            _attempts.Add(newAttempt);
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
