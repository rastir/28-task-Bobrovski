using System;
using System.Collections.Generic;

namespace Level1Space
{
    public static class Level1
    {
       public static bool TransformTransform(int[] A, int N)
        {
            List<int> B = new List<int>();
            int k;
            int maxValue;

            for (int i = 0; i <= A.Length - 1; i++)
            {

                for (int j = 0; j <= A.Length - i - 1; j++)
                {
                    k = i + j;
                    maxValue = 0;

                    for (int x = j; x <= k; x++)
                    {
                        if (A[x] > maxValue)
                        {
                            maxValue  = A[x];
                        }
                    }
                        B.Add(maxValue);
                }
            }
            List<int> C = new List<int>();

            for (int i = 0; i <= B.Count - 1; i++)
            {
                for (int j = 0; j <= B.Count - i - 1; j++)
                {
                    k = i + j;
                    maxValue = 0;
                    for (int x = j; x <= k; x++)
                    {
                        if (B[x] > maxValue)
                        {
                            // найден больший элемент
                            maxValue = B[x];
                        }
                    }
                    C.Add(maxValue);
                }
            }

            int summ = 0;
            for (int x = 0; x < C.Count; x++)
            {
                summ += C[x];
            }

            if (summ % 2 == 0)
                return true;
            else
                return false;
        }
    }
}
