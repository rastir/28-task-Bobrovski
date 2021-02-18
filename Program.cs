using System;

namespace ConsoleApp1
{
    class Program
    {
        static int Squirrel(int N)
        {
            int factorial = 1;
            if (N != 0)
            {
                for (int i = 2; i <= N; i++)
                {
                    factorial *= i;
                }
                //Console.WriteLine("факториал" + factorial);
            }
            if (factorial < 10)
            {
                return factorial;
            }
            else
                return factorial - ((factorial % 10) / 10);
        }
        static int GetFirstNumber(int number)
        {
            if (number < 10)
            {
                return number;
            }
            return GetFirstNumber((number - (number % 10)) / 10);
        }
        static void Main()
        {
            int n = 0;
            Console.Write("Number: ");
            n = Convert.ToInt32(Console.ReadLine());
            int first = GetFirstNumber(Squirrel(n));
            Console.WriteLine(first);
            Console.ReadLine();
        }
    }
}
