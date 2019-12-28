using System;

namespace silniarekurencyjnie
{

    class Program
    {
        private static int silnia1(int i)
        {
            if (i < 1)
                return 1;
            else
                return i * silnia1(i - 1);
        }

        static void Main(string[] args)
        {
            string line;
            int n;

            Console.WriteLine("podaj dla jakiej liczby obliczyc silnie.\n");
            line = Console.ReadLine();
            n = int.Parse(line);

            Console.WriteLine(n + "! = " + silnia1(n));


        }
    }
}