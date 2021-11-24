using System;
using System.Collections.Generic;

namespace Level1Space
{
    public static class Level1
    {
       public static bool TransformTransform(int[] A, int N)
        {
            int[] B = new int[N];
            int k = 0;
            int r = N;

            for (int i = 0; i < N - 1; i++)
            {
                for (int j = 0; j < N - i - 1; j++)
                {
                    k = i + j;
                    int maxValue = int.MinValue;
                    for (int x = j; x < k; x++)
                    {
                        if (A[x] > maxValue)
                        {
                            // найден больший элемент
                            maxValue  = A[x];
                        }
                    }
                    if (r > 0)
                        B[r - 1] = maxValue;
                    else if (r == 0)
                        B[r] = maxValue;
                    if (r > 0)
                        r--;
                }
            }

            return true;
        }
    }
}
