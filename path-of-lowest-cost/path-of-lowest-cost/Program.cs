using System;

namespace path_of_lowest_cost
{
    class Program
    {
        static void Main(string[] args)
        {
            var challenge = challenge1();
            // var challenge = challenge2();
            // var challenge = challenge3();
            // var challenge = challenge4();

            var isSolved = false;
            var startingRowIndex = 0;

            while(!isSolved)
            {
                isSolved = challenge.Solve(startingRowIndex);
                startingRowIndex++;
            }

            if (isSolved)
            {
                Console.WriteLine("Yes");
                Console.WriteLine(challenge.solution.ToString());
                for(var i = 0; i < challenge.selectedColumnValues.Length; i++)
                {
                    Console.Write(challenge.selectedColumnValues[i].ToString() + ",");
                }
            }

            Console.ReadLine();
        }

        static CodeChallenge challenge1()
        {
            var challenge = new CodeChallenge(3, 5);
            challenge.AddValueToArray(0, 0, 1);
            challenge.AddValueToArray(0, 1, 2);
            challenge.AddValueToArray(0, 2, 2);
            challenge.AddValueToArray(0, 3, 2);
            challenge.AddValueToArray(0, 4, 2);

            challenge.AddValueToArray(1, 0, 2);
            challenge.AddValueToArray(1, 1, 1);
            challenge.AddValueToArray(1, 2, 2);
            challenge.AddValueToArray(1, 3, 2);
            challenge.AddValueToArray(1, 4, 2);

            challenge.AddValueToArray(2, 0, 2);
            challenge.AddValueToArray(2, 1, 2);
            challenge.AddValueToArray(2, 2, 1);
            challenge.AddValueToArray(2, 3, 1);
            challenge.AddValueToArray(2, 4, 1);

            return challenge;
        }

        static CodeChallenge challenge2()
        {
            var challenge = new CodeChallenge(5, 6);
            challenge.AddValueToArray(0, 0, 3);
            challenge.AddValueToArray(0, 1, 4);
            challenge.AddValueToArray(0, 2, 1);
            challenge.AddValueToArray(0, 3, 2);
            challenge.AddValueToArray(0, 4, 8);
            challenge.AddValueToArray(0, 4, 6);

            challenge.AddValueToArray(1, 0, 6);
            challenge.AddValueToArray(1, 1, 1);
            challenge.AddValueToArray(1, 2, 8);
            challenge.AddValueToArray(1, 3, 2);
            challenge.AddValueToArray(1, 4, 7);
            challenge.AddValueToArray(1, 4, 4);

            challenge.AddValueToArray(2, 0, 5);
            challenge.AddValueToArray(2, 1, 9);
            challenge.AddValueToArray(2, 2, 3);
            challenge.AddValueToArray(2, 3, 9);
            challenge.AddValueToArray(2, 4, 9);
            challenge.AddValueToArray(2, 4, 5);

            challenge.AddValueToArray(3, 0, 8);
            challenge.AddValueToArray(3, 1, 4);
            challenge.AddValueToArray(3, 2, 1);
            challenge.AddValueToArray(3, 3, 3);
            challenge.AddValueToArray(3, 4, 2);
            challenge.AddValueToArray(3, 4, 6);

            challenge.AddValueToArray(4, 0, 3);
            challenge.AddValueToArray(4, 1, 7);
            challenge.AddValueToArray(4, 2, 2);
            challenge.AddValueToArray(4, 3, 8);
            challenge.AddValueToArray(4, 4, 6);
            challenge.AddValueToArray(4, 4, 4);

            return challenge;
        }

        static CodeChallenge challenge3()
        {
            var challenge = new CodeChallenge(5, 6);
            challenge.AddValueToArray(0, 0, 3);
            challenge.AddValueToArray(0, 1, 4);
            challenge.AddValueToArray(0, 2, 1);
            challenge.AddValueToArray(0, 3, 2);
            challenge.AddValueToArray(0, 4, 8);
            challenge.AddValueToArray(0, 4, 6);

            challenge.AddValueToArray(1, 0, 6);
            challenge.AddValueToArray(1, 1, 1);
            challenge.AddValueToArray(1, 2, 8);
            challenge.AddValueToArray(1, 3, 2);
            challenge.AddValueToArray(1, 4, 7);
            challenge.AddValueToArray(1, 4, 4);

            challenge.AddValueToArray(2, 0, 5);
            challenge.AddValueToArray(2, 1, 9);
            challenge.AddValueToArray(2, 2, 3);
            challenge.AddValueToArray(2, 3, 9);
            challenge.AddValueToArray(2, 4, 9);
            challenge.AddValueToArray(2, 4, 5);

            challenge.AddValueToArray(3, 0, 8);
            challenge.AddValueToArray(3, 1, 4);
            challenge.AddValueToArray(3, 2, 1);
            challenge.AddValueToArray(3, 3, 3);
            challenge.AddValueToArray(3, 4, 2);
            challenge.AddValueToArray(3, 4, 6);

            challenge.AddValueToArray(4, 0, 3);
            challenge.AddValueToArray(4, 1, 7);
            challenge.AddValueToArray(4, 2, 2);
            challenge.AddValueToArray(4, 3, 1);
            challenge.AddValueToArray(4, 4, 2);
            challenge.AddValueToArray(4, 4, 3);

            return challenge;
        }

        static CodeChallenge challenge4()
        {
            var challenge = new CodeChallenge(3, 5);
            challenge.AddValueToArray(0, 0, 19);
            challenge.AddValueToArray(0, 1, 10);
            challenge.AddValueToArray(0, 2, 19);
            challenge.AddValueToArray(0, 3, 10);
            challenge.AddValueToArray(0, 4, 19);

            challenge.AddValueToArray(1, 0, 21);
            challenge.AddValueToArray(1, 1, 23);
            challenge.AddValueToArray(1, 2, 20);
            challenge.AddValueToArray(1, 3, 19);
            challenge.AddValueToArray(1, 4, 12);

            challenge.AddValueToArray(2, 0, 20);
            challenge.AddValueToArray(2, 1, 12);
            challenge.AddValueToArray(2, 2, 20);
            challenge.AddValueToArray(2, 3, 11);
            challenge.AddValueToArray(2, 4, 10);

            return challenge;
        }
    }
}
