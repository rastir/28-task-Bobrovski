using System;

namespace ConsoleApp1
{
    public static class Program
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
            if (factorial < 10)
            {
                return factorial;
            }
            else
                return factorial - ((factorial % 10) / 10);
        }
    }
}
