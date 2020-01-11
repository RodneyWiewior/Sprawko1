using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tablice
{
    class Program
    {
        static void fibonacci()
        {
            ulong[] tab = new ulong[100];
            tab[0] = 1;
            tab[1] = 2;
            for (int i = 2; i < 100; i++)
                tab[i] = tab[i - 1] + tab[i - 2];

            Console.WriteLine("Kolejne liczby Fibonacciego: ");
            foreach (ulong i in tab)
            {
                Console.Write(i.ToString() + " ");
            }

            Console.ReadLine();
        }


        static void Main(string[] args)
        {
            int[,] tab = new int[10, 10];
            int r = 2;
            for (int i = 0; i < 10; i++)
            { 
                for (int j = 0; j < 10; j++)
                {
                    tab[i, j] = r;
                    r = r + 2;
                    Console.Write(r + " ");

                }
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}
