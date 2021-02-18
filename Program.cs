using System;

namespace Level1Space
{
    public static class Program
    {
        public static int squirrel(int N)
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
