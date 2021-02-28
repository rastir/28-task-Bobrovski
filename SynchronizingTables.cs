using System;

namespace Level1Space
{
    public static class Level1
    {
        public static int [] SynchronizingTables(int N, int [] ids, int [] salary)
        {
            int[] ids2 = new int[N];
            Array.Copy(ids, ids2, N);
            int[] ReSalary2 = new int[N];
            if (N > 1)
            {
                for (int i = 0; i < N - 1; i++)
                {
                    for (int j = i + 1; j < N; j++)
                    {
                        if (ids2[i] > ids2[j])
                        {
                            int b = ids2[i];
                            ids2[i] = ids2[j];
                            ids2[j] = b;
                        }
                    }
                }
                for (int i = 0; i < N - 1; i++) 
                {
                    for (int j = i + 1; j < N; j++)
                    {
                        if (salary[i] > salary[j])
                        {
                            int b = salary[i];
                            salary[i] = salary[j];
                            salary[j] = b;
                        }
                    }
                }
                int[,] Concantenated = new int[N, 2];
                for (int i = 0; i < N; i++)
                    Concantenated[i, 0] = ids2[i];
                for (int i = 0; i < N; i++)
                    Concantenated[i, 1] = salary[i];
                int k = 0;
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < N; j++)
                    {
                        if (ids[i] == Concantenated[j, 0])
                        {
                            ReSalary2[k] = Concantenated[j, 1];
                            k++;
                            break;
                        }
                    }
                }
            }
            return ReSalary2;
        }
    }
}
