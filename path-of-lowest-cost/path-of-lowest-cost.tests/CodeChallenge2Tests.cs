using System.Collections.Generic;
using NUnit.Framework;

namespace path_of_lowest_cost.tests
{
    [TestFixture]
    public class CodeChallenge2Tests
    {
        [TestFixture]
        internal class Single_Dimension_Matrices
        {
            [Test]
            public void Should_Solve_Challenge1()
            {
                // arrange
                var expectedSelectedMatrixPoints = new List<int>() { 0, 1, 1, 1, 1 };

                int[,] testGrid = new int[1, 5];
                testGrid[0, 0] = 1;
                testGrid[0, 1] = 1;
                testGrid[0, 2] = 1;
                testGrid[0, 3] = 1;
                testGrid[0, 4] = 1;

                var sut = new CodeChallenge2(testGrid);

                // act
                var result = sut.SolveChallenge();

                // assert
                Assert.That(result.isSolved == "Yes");
                Assert.That(result.solutionTotal == 5);
                Assert.That(result.selectedMatrixPoints[0] == expectedSelectedMatrixPoints[0]);
                Assert.That(result.selectedMatrixPoints[1] == expectedSelectedMatrixPoints[1]);
                Assert.That(result.selectedMatrixPoints[2] == expectedSelectedMatrixPoints[2]);
                Assert.That(result.selectedMatrixPoints[3] == expectedSelectedMatrixPoints[3]);
                Assert.That(result.selectedMatrixPoints[4] == expectedSelectedMatrixPoints[4]);
            }

        }

    }
}
