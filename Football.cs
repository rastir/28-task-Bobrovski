using System;
using System.Collections.Generic;

namespace Level1Space
{
    public static class Level1
    {
        public static bool Football(int[] F, int N)
        {
            int startindex = 0;
            int endindex = 0;
            bool true_startindex = false;

            bool notOrder = false;
            int[] F_copy = new int[N];
            Array.Copy(F, 0, F_copy, 0, N);
            int temp;

            for (int i = 1; i < F.Length; i++)
            {
                if (F[i - 1] > F[i])
                {
                    if (startindex == 0 && true_startindex == false)
                    {
                        startindex = i - 1;
                        true_startindex = true;
                    }
                }
                if (i > 1 && F[i] > F[i - 1] && F[i - 2] > F[i - 1])
                {
                    if (endindex == 0)
                        endindex = i - 1;
                }
            }
            if (endindex == 0)
                endindex = startindex + (N - (startindex + 1));
            temp = F_copy[startindex];
            F_copy[startindex] = F_copy[endindex];
            F_copy[endindex] = temp;

            for (int i = 1; i < F_copy.Length; i++)
            {
                if (F_copy[i] < F_copy[i - 1])
                    notOrder = true;
            }
            if (notOrder == false)
                return true;
            else
            {
                Array.Reverse(F, startindex,  endindex - startindex + 1);

                for (int i = 1; i < F.Length; i++)
                {
                    if (F[i] < F[i - 1])
                        notOrder = true;
                }
                if (notOrder == false)
                    return true;
                else 
                    return false;
            }
        }
    }
}
