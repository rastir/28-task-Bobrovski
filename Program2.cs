using System;

namespace ConsoleApp1
{
    class Program
    {
        public static int Squirrel(int N)
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
        }
    }
}
