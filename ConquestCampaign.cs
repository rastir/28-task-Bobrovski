namespace Level1Space
{
    public static class Level1
    {
        public static int ConquestCampaign(int N, int M, int L, int[] battalion)
        {
            int[,] dynarr = new int[N, M];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    dynarr[i, j] = 0;
                }
                Console.WriteLine("");
            }
            for (int i = 0; i < battalion.Length - 1; i++)
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
            bool prizn = false;
            while (prizn == false)
            {
                day++;
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
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < M; j++)
                    {
                        if (dynarr[i, j] == 0)
                            k++;
                        else
                            continue;
                    }
                }
                if (k == 0)
                {
                    prizn = true;
                    if (prizn == true)
                        break;
                }
            }
            return day;
        }
    }
}
