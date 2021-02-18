using System;

namespace Level1Space
{
    public static class Level1
    {
        public static int odometer(int[] oksana)
        {
            int distance = 0;
            for (int i = 0; i < oksana.Length - 1; i++)
            {
                if (i % 2 == 0)
                {
                    if (i > 1)
                    {
                        int b = oksana[i + 1] - oksana[i - 1];
                        distance += oksana[i] *b;
                    }
                    else 
                        distance += oksana[i] * oksana[i + 1];
                    i++;
                }
            }
            return distance;
        }
    }
}
