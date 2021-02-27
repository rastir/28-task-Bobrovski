using System;

namespace Level1Space
{
    public static class Level1
    {
        public static int ConquestCampaign(int N, int M, int L, int[] battalion)
        {
            int[,] dynarr = new int[N + 1, M + 1];
            for (int i = 1; i <= N; i++)
            {
                for (int j = 1; j <= M; j++)
                {
                    dynarr[Level1.S(i), Level1.S(j)] = 0;
                }
            }
            for (int i = 0; i < battalion.Length; i++)
            {
                if (i % 2 == 0)
                {
                    int a = battalion[i];
                    int b = battalion[i + 1];
                    dynarr[a, b] = 1;
                }
                else
                    continue;
            }
            int day = 1;
            day = WhileDo(N, M, day, dynarr);
            return day;
        }
        public static int S(int indexE)
        {
            return indexE - 1;
        }
        public static int WhileDo(int N, int M, int day, int[,] dynarr)
        {
            bool prizn = false;
            while (prizn == false)
            {
                int k = 0;
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < M; j++)
                    {
                        if (dynarr[i, j] != 0)
                            dynarr[i, j]++;
                        if (dynarr[i, j] >= 2)
                        {
                            if (i > 0)
                                dynarr[i - 1, j]++;
                            if (i < N - 1)
                                dynarr[i + 1, j]++;
                            if (j > 0)
                                dynarr[i, j - 1]++;
                            if (j < M - 1)
                                dynarr[i, j + 1]++;
                        }
                    }
                }
                day++;
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < M; j++)
                    {
                        if (dynarr[i, j] == 0)
                            k++;
                    }
                }
                if (k == 0)
                {
                    prizn = true;
                    break;
                }
            }
            return day;
        }
    }
}
