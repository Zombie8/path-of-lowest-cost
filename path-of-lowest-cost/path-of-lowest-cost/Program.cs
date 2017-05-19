using System;

namespace path_of_lowest_cost
{
    class Program
    {
        static void Main(string[] args)
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

            var solution = challenge.Solve();

            Console.WriteLine(solution);
            Console.ReadLine();
        }
    }
}
