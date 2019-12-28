using System;

namespace iteracyjnieSilnia
{
    class Program
    {
        private static int silnia(int  n)
        { 
            int result = 1;
          
            for (int i = 1; i <= n; i++)
            {
                result*= i;
            }
            return result;
        }
        static void Main(string[] args)
        {
            string line;
            int n;

            Console.WriteLine("podaj dla jakiej liczby obliczyc silnie.\n");
            line = Console.ReadLine();
            n = int.Parse(line);
            if(n>=0){
                Console.WriteLine(n + "! = " + silnia(n));

            }
            else
            {
                Console.WriteLine("nie istnieje silnia ujemna");

            }
            

        }
	

	}
 }

