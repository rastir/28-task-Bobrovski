using System;

namespace Level1Space
{
    public static class Level1
    {
        public static int [] MadMax(int N, int [] Tele)
        {
            if (N > 1)
            {
                for (int i = 0; i < N - 1; i++)
                {
                    for (int j = i + 1; j < N; j++)
                    {
                        if (Tele[i] > Tele[j])
                        {
                            int b = Tele[i];
                            Tele[i] = Tele[j];
                            Tele[j] = b;
                        }
                    }
                }
                decimal P = (decimal)N / 2; ;
                int M = (int)Math.Round(P);
                for (int i = M - 1; i < N; i++)
                {
                    for (int j = i; j < N - 1; j++)
                    {
                        if (Tele[i] < Tele[j + 1])
                        {
                            int b = Tele[i];
                            Tele[i] = Tele[j + 1];
                            Tele[j + 1] = b;
                        }
                    }
                }
            }            
            return Tele;
        }
    }
}
