using System;

namespace path_of_lowest_cost
{
    class Program
    {
        static void Main(string[] args)
        {
            //var testGrid = testGrid1();       // YES, 5, [1, 1, 1, 1, 1]
            //var testGrid = testGrid2();       // YES, 50, [1, 1, 1, 1, 1]
            //var testGrid = testGrid3();       // NO, 51, [1, 1, 1]
            //var testGrid = testGrid4();       // YES, 0, [1, 1, 1, 1, 1]
            //var testGrid = testGrid5();       // YES, 5, [1, 1, 1, 1, 1]
            //var testGrid = testGrid6();       // YES, 5, [2, 2, 2, 2, 2]
            //var testGrid = testGrid7();       // YES, 5, [1, 2, 1, 2, 1]
            //var testGrid = testGrid8();       // YES, 5, [2, 1, 2, 1, 2]
            //var testGrid = testGrid9();       // YES, 50, [2, 1, 2, 1, 2]
            //var testGrid = testGrid10();      // YES, 5, [3, 3, 3, 3, 3]
            var testGrid = testGrid11();        // YES, 5, [3, 3, 3, 3, 3]

            var challenge = new CodeChallenge2(testGrid);
            var result = challenge.SolveChallenge();

            Console.WriteLine(result.isSolved);
            Console.WriteLine(result.solutionTotal.ToString());
            foreach(var value in result.selectedMatrixPoints)
            {
                Console.Write(value.ToString() + ", ");
            }

            Console.ReadLine();
        }

        //===========================//
        // SINGLE DIMENSION MATRICES //
        //===========================//
        static int[,] testGrid1()
        {
            int[,] testGrid = new int[1, 5];
            testGrid[0, 0] = 1;
            testGrid[0, 1] = 1;
            testGrid[0, 2] = 1;
            testGrid[0, 3] = 1;
            testGrid[0, 4] = 1;

            return testGrid;
        }

        static int[,] testGrid2()
        {
            int[,] testGrid = new int[1, 5];
            testGrid[0, 0] = 10;
            testGrid[0, 1] = 10;
            testGrid[0, 2] = 10;
            testGrid[0, 3] = 10;
            testGrid[0, 4] = 10;

            return testGrid;
        }

        static int[,] testGrid3()
        {
            int[,] testGrid = new int[1, 5];
            testGrid[0, 0] = 25;
            testGrid[0, 1] = 25;
            testGrid[0, 2] = 1;
            testGrid[0, 3] = 1;
            testGrid[0, 4] = 1;

            return testGrid;
        }

        static int[,] testGrid4()
        {
            int[,] testGrid = new int[1, 5];
            testGrid[0, 0] = 0;
            testGrid[0, 1] = 0;
            testGrid[0, 2] = 0;
            testGrid[0, 3] = 0;
            testGrid[0, 4] = 0;

            return testGrid;
        }

        //===========================//
        // DOUBLE DIMENSION MATRICES //
        //===========================//
        static int[,] testGrid5()
        {
            int[,] testGrid = new int[2, 5];
            testGrid[0, 0] = 1;
            testGrid[0, 1] = 1;
            testGrid[0, 2] = 1;
            testGrid[0, 3] = 1;
            testGrid[0, 4] = 1;

            testGrid[1, 0] = 2;
            testGrid[1, 1] = 2;
            testGrid[1, 2] = 2;
            testGrid[1, 3] = 2;
            testGrid[1, 4] = 2;

            return testGrid;
        }

        static int[,] testGrid6()
        {
            int[,] testGrid = new int[2, 5];
            testGrid[0, 0] = 2;
            testGrid[0, 1] = 2;
            testGrid[0, 2] = 2;
            testGrid[0, 3] = 2;
            testGrid[0, 4] = 2;

            testGrid[1, 0] = 1;
            testGrid[1, 1] = 1;
            testGrid[1, 2] = 1;
            testGrid[1, 3] = 1;
            testGrid[1, 4] = 1;

            return testGrid;
        }

        static int[,] testGrid7()
        {
            int[,] testGrid = new int[2, 5];
            testGrid[0, 0] = 1;
            testGrid[0, 1] = 2;
            testGrid[0, 2] = 1;
            testGrid[0, 3] = 2;
            testGrid[0, 4] = 1;

            testGrid[1, 0] = 2;
            testGrid[1, 1] = 1;
            testGrid[1, 2] = 2;
            testGrid[1, 3] = 1;
            testGrid[1, 4] = 2;

            return testGrid;
        }

        static int[,] testGrid8()
        {
            int[,] testGrid = new int[2, 5];
            testGrid[0, 0] = 2;
            testGrid[0, 1] = 1;
            testGrid[0, 2] = 2;
            testGrid[0, 3] = 1;
            testGrid[0, 4] = 2;

            testGrid[1, 0] = 1;
            testGrid[1, 1] = 2;
            testGrid[1, 2] = 1;
            testGrid[1, 3] = 2;
            testGrid[1, 4] = 1;

            return testGrid;
        }

        static int[,] testGrid9()
        {
            int[,] testGrid = new int[2, 5];
            testGrid[0, 0] = 20;
            testGrid[0, 1] = 10;
            testGrid[0, 2] = 20;
            testGrid[0, 3] = 10;
            testGrid[0, 4] = 20;

            testGrid[1, 0] = 10;
            testGrid[1, 1] = 20;
            testGrid[1, 2] = 10;
            testGrid[1, 3] = 20;
            testGrid[1, 4] = 10;

            return testGrid;
        }

        //===========================//
        // TRIPLE DIMENSION MATRICES //
        //===========================//
        static int[,] testGrid10()
        {
            int[,] testGrid = new int[3, 5];
            testGrid[0, 0] = 3;
            testGrid[0, 1] = 3;
            testGrid[0, 2] = 3;
            testGrid[0, 3] = 3;
            testGrid[0, 4] = 3;

            testGrid[1, 0] = 2;
            testGrid[1, 1] = 2;
            testGrid[1, 2] = 2;
            testGrid[1, 3] = 2;
            testGrid[1, 4] = 2;

            testGrid[2, 0] = 1;
            testGrid[2, 1] = 1;
            testGrid[2, 2] = 1;
            testGrid[2, 3] = 1;
            testGrid[2, 4] = 1;

            return testGrid;
        }

        // PIXEL TESTS //
        static int[,] testGrid11()
        {
            int[,] testGrid = new int[5, 6];
            testGrid[0, 0] = 3;
            testGrid[0, 1] = 4;
            testGrid[0, 2] = 1;
            testGrid[0, 3] = 2;
            testGrid[0, 4] = 8;
            testGrid[0, 5] = 6;

            testGrid[1, 0] = 6;
            testGrid[1, 1] = 1;
            testGrid[1, 2] = 8;
            testGrid[1, 3] = 2;
            testGrid[1, 4] = 7;
            testGrid[1, 5] = 4;

            testGrid[2, 0] = 5;
            testGrid[2, 1] = 9;
            testGrid[2, 2] = 3;
            testGrid[2, 3] = 9;
            testGrid[2, 4] = 9;
            testGrid[2, 5] = 5;

            testGrid[3, 0] = 8;
            testGrid[3, 1] = 4;
            testGrid[3, 2] = 1;
            testGrid[3, 3] = 3;
            testGrid[3, 4] = 2;
            testGrid[3, 5] = 6;

            testGrid[4, 0] = 3;
            testGrid[4, 1] = 7;
            testGrid[4, 2] = 2;
            testGrid[4, 3] = 8;
            testGrid[4, 4] = 6;
            testGrid[4, 5] = 4;

            return testGrid;
        }
    }
}