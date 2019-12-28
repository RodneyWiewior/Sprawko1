using System;

namespace silniaRekurencyjnie
{

    class Program
    {
        private static int silnia(int i)
        {
            if (i < 1)
                return 1;
            else
                return i * silnia(i - 1);
        }

        static void Main(string[] args)
        {
            string line;
            int n;

            Console.WriteLine("podaj dla jakiej liczby obliczyc silnie.\n");
            line = Console.ReadLine();
            n = int.Parse(line);

            if (n >= 0)
            {
                Console.WriteLine(n + "! = " + silnia(n));

            }
            else
            {
                Console.WriteLine("nie istnieje silnia ujemna");

            }


        }
    }
}