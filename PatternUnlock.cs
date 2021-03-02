using System;

namespace Level1Space
{
    public static class Level1
    {
        public static string PatternUnlock(int N, int[] hits)
        {
            if (N > 1)
            {
                int[,] block = new int[3, 3] { { 6, 1, 9 }, { 5, 2, 8 }, { 4, 3, 7 } };
                int k1 = 0;
                int k2 = 0;
                int k3 = 0;
                int M = N * 2;
                int[] coord = new int[M];
                for (int i = 0; i < M; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (hits[k3] == block[k2, j])
                        {
                            coord[k1] = k2;
                            k1++;
                            coord[k1] = j;
                            k1++;
                            k3++;
                            k2 = 0;
                            break;
                        }
                    }
                    if (k2 == 2)
                        k2 = 0;
                    else
                        k2++;
                    if (k3 == N)
                        break;
                }
                double summ = 0;
                for (int i = 0; i < M - 2; i++)
                {
                    if (i % 2 == 0)
                    {
                        if ((Math.Abs(coord[i] - coord[i + 2]) + Math.Abs(coord[i + 1] - coord[i + 3])) == 1)
                            summ++;
                        else
                            summ += 1.414213;
                    }
                }
                summ = Math.Round(summ, 5);
                string summ2 = summ.ToString(format: "0.00000000");
                summ2 = summ2.Replace(@",", "").Replace(@"0", "");
                return summ2;
            }
            else
                return "1";
        }
    }
}
