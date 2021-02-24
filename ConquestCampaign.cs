amespace Level1Space
{
    public static class Level1
    {
        public static int ConquestCampaign(int N, int M, int L, int[] battalion)
        {
            int k = 0;
            int day;
            L *= 2;
            int[] dynarr = new int[N*M];
            --for (day=1; )
            for (int i = 0; i < battalion.Length; i++)
            {
                if (i % 2 == 0)
                {
                    if ((battalion[i] > 1) && (battalion[i + 1] == 1))
                    {
                        dynarr[k] = battalion[i];
                        k++;
                        dynarr[k] = battalion[i + 1];
                        k++;
                    }
                    else if (battalion[i] > 1)
                    {
                        dynarr[k] = battalion[i];
                        k++;
                        dynarr[k] = battalion[i + 1] - 1;
                        k++;
                    }
                    if (battalion[i]<N)
                    {
                        dynarr[k] = battalion[i];
                        k++;
                        dynarr[k] = battalion[i + 1] + 1;
                        k++;
                    }
                }
                else
                {
                    if ((battalion[i] > 1) && (battalion[i - 1] == 1))
                    {
                        dynarr[k] = battalion[i-1];
                        k++;
                        dynarr[k] = battalion[i];
                        k++;
                    }
                    else if (battalion[i] > 1)
                    {
                        dynarr[k] = battalion[i - 1] - 1;
                        k++;
                        dynarr[k] = battalion[i];
                        k++;
                    }
                    if (battalion[i] < M)
                    {
                        dynarr[k] = battalion[i-1]+1;
                        k++;
                        dynarr[k] = battalion[i];
                    }
                } 
            }
            day++;
            for (int i=0; i < dynarr.Length; i++)
            {
                Console.WriteLine(i+"й индекс равен числу "+dynarr[i] + " i ");
            }
            return day;
        }
    }
}
