using System.Collections.Generic;
using NUnit.Framework;
using path_of_lowest_cost;

namespace path_of_lowest_cost.tests
{
    [TestFixture]
    public class CodeChallengeTests
    {
        [TestFixture]
        internal class Single_Dimension_Matrices
        {
            [Test]
            public void Should_Solve_Challenge1()
            {
                // arrange
                var expectedSelectedMatrixPoints = new List<int>() { 1, 1, 1, 1, 1 };

                int[,] testGrid = Program.testGrid1();

                var sut = new CodeChallenge(testGrid);

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

            [Test]
            public void Should_Solve_Challenge2()
            {
                // arrange
                var expectedSelectedMatrixPoints = new List<int>() { 1, 1, 1, 1, 1 };

                int[,] testGrid = Program.testGrid2();

                var sut = new CodeChallenge(testGrid);

                // act
                var result = sut.SolveChallenge();

                // assert
                Assert.That(result.isSolved == "Yes");
                Assert.That(result.solutionTotal == 50);
                Assert.That(result.selectedMatrixPoints[0] == expectedSelectedMatrixPoints[0]);
                Assert.That(result.selectedMatrixPoints[1] == expectedSelectedMatrixPoints[1]);
                Assert.That(result.selectedMatrixPoints[2] == expectedSelectedMatrixPoints[2]);
                Assert.That(result.selectedMatrixPoints[3] == expectedSelectedMatrixPoints[3]);
                Assert.That(result.selectedMatrixPoints[4] == expectedSelectedMatrixPoints[4]);
            }

            [Test]
            public void Should_Solve_Challenge3()
            {
                // arrange
                var expectedSelectedMatrixPoints = new List<int>() { 1, 1, 1 };

                int[,] testGrid = Program.testGrid3();

                var sut = new CodeChallenge(testGrid);

                // act
                var result = sut.SolveChallenge();

                // assert
                Assert.That(result.isSolved == "No");
                Assert.That(result.solutionTotal == 51);
                Assert.That(result.selectedMatrixPoints[0] == expectedSelectedMatrixPoints[0]);
                Assert.That(result.selectedMatrixPoints[1] == expectedSelectedMatrixPoints[1]);
                Assert.That(result.selectedMatrixPoints[2] == expectedSelectedMatrixPoints[2]);
            }

            [Test]
            public void Should_Solve_Challenge4()
            {
                // arrange
                var expectedSelectedMatrixPoints = new List<int>() { 1, 1, 1, 1, 1 };

                int[,] testGrid = Program.testGrid4();

                var sut = new CodeChallenge(testGrid);

                // act
                var result = sut.SolveChallenge();

                // assert
                Assert.That(result.isSolved == "Yes");
                Assert.That(result.solutionTotal == 0);
                Assert.That(result.selectedMatrixPoints[0] == expectedSelectedMatrixPoints[0]);
                Assert.That(result.selectedMatrixPoints[1] == expectedSelectedMatrixPoints[1]);
                Assert.That(result.selectedMatrixPoints[2] == expectedSelectedMatrixPoints[2]);
                Assert.That(result.selectedMatrixPoints[3] == expectedSelectedMatrixPoints[3]);
                Assert.That(result.selectedMatrixPoints[4] == expectedSelectedMatrixPoints[4]);
            }
        }

        [TestFixture]
        internal class Double_Dimension_Matrices
        {
            [Test]
            public void Should_Solve_Challenge5()
            {
                // arrange
                var expectedSelectedMatrixPoints = new List<int>() { 1, 1, 1, 1, 1 };

                int[,] testGrid = Program.testGrid5();

                var sut = new CodeChallenge(testGrid);

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
