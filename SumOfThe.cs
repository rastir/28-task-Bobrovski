using System;

namespace Level1Space
{
    public static class Level1
    {
        public static int SumOfThe(int N, int[] data)
        {
            int result = 0;
            int sum = 0;
            //char[] s1 = s.ToCharArray();
            //string[,] s3 = new string[s.Length, s.Length];
            for (int i = 0; i < data.Length; i++)
            {
                sum = 0;
                for (int j = 0; j < data.Length; j++)
                {
                    if (i == j)
                        continue;
                    else
                        sum += data[j];
                }
                if (data[i] == sum)
                {
                    result = sum;
                    break;
                }
            }
            return result;
        }
    }
}
