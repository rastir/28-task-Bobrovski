using System;
using System.Collections.Generic;

namespace Level1Space
{
    public static class Level1
    {
        public static string Keymaker(int k)
        {
            int[] Array_Logic = new int[k];
            for (int i = 0; i < Array_Logic.Length; i++)
            {
                Array_Logic[i] = 1;//сразу открываем все двери
            }

            for (int i = 1; i < Array_Logic.Length; i++)
            {
                for (int j = 1; j < Array_Logic.Length; j++)
                {
                    if ((j+ 1) % (i + 1) == 0)
                    {
                        if (Array_Logic[j] == 0)
                            Array_Logic[j] = 1;
                        else
                            Array_Logic[j] = 0;
                    }
                }
            }
            
            string s = "";
            foreach (int i in Array_Logic)
            {
                s += i;
            }
            return s;
        }
    }
}
