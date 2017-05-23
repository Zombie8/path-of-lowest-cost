using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace path_of_lowest_cost
{
    public class CodeChallenge3
    {
        private readonly int[,] _grid;
        private List<ChallengeAttempt> _attempts;

        public CodeChallenge3(int[,] grid)
        {
            _grid = grid;
            _attempts = new List<ChallengeAttempt>();
        }

        public ChallengeAttempt SolveChallenge()
        {
            // iterate through each row in grid
            for (int i = 0; i <= _grid.GetLength(0); i++)
            {
                var pathOfLeastCost = AttemptChallenge(i, 0, 0, new List<int>());
                _attempts.Add(pathOfLeastCost);
            }

            // determine which iteration was the least cost
            var leastCostAttempt = _attempts.OrderBy(x => x.solutionTotal).First();

            // return least cost row
            return leastCostAttempt;
        }

        private ChallengeAttempt AttemptChallenge(int row, int column, int previousTotal, List<int> previousChosenColumns)
        {
            // CHECK IF ROW NEEDS TO FLIP TO TOP
            if (row < 0)
            {
                row = _grid.GetLength(0) - 1;
            }

            // CHECK IF ROW NEEDS TO FLIP TO BOTTOM
            if (row > _grid.GetLength(0) - 1)
            {
                row = 0;
            }

            var currentTotal = previousTotal + _grid[row, column];
            var ChosenColumns = new List<int>(previousChosenColumns);
            ChosenColumns.Add(row + 1);

            // EXIT CONDITION 1
            if (previousTotal > 50) // TOTAL EXCEEDS 50
            {
                return new ChallengeAttempt()
                {
                    isSolved = "No",
                    solutionTotal = previousTotal,
                    selectedMatrixPoints = ChosenColumns
                };
            }

            // EXIT CONDITION 2
            if (column >= _grid.GetLength(1) - 1) // REACH THE END OF THE MATRIX
            {
                return new ChallengeAttempt()
                {
                    isSolved = "Yes",
                    solutionTotal = currentTotal,
                    selectedMatrixPoints = ChosenColumns
                };
            }

            // RECURSIVELY FETCH TOP, MIDDLE, AND BOTTOM VALUES
            var top = AttemptChallenge(row + 1, column + 1, currentTotal, ChosenColumns);
            var middle = AttemptChallenge(row, column + 1, currentTotal, ChosenColumns);
            var bottom = AttemptChallenge(row - 1, column + 1, currentTotal, ChosenColumns);

            // DETERMINE WHICH VALUE TO RETURN WITHIN THIS RECURSIVE FUNCTION
            if (top.solutionTotal <= middle.solutionTotal && top.solutionTotal < bottom.solutionTotal)
            {
                return top;
            }
            else if (middle.solutionTotal < bottom.solutionTotal)
            {
                return middle;
            }
            else
            {
                return bottom;
            }
        }
    }

    public class ChallengeAttempt
    {
        public string isSolved { get; set; }
        public int solutionTotal { get; set; }
        public List<int> selectedMatrixPoints { get; set; }

        public ChallengeAttempt()
        {
            selectedMatrixPoints = new List<int>();
        }
    }
}
