using System;

namespace Level1Space
{
    public static class Level1
    {
        public static bool TankRush(int H1, int W1, string S1, int H2, int W2, string S2)
        {
            char[] text1 = S1.ToCharArray();
            char[] text2 = S2.ToCharArray();
            int result = 0;

            int y = 0;
            int k = 0;
            int a = 0;
            int b = 0;
            bool secondstring = false;

            while (result < H2 * W2 && a < S1.Length)
            {
                if (text2[b] == text1[a] && text2[b].ToString() != " ")
                {
                    result++;
                    if (y == 0)
                        k = a; 
                    if (y < W2)
                        y++;
                    if (y == W2)
                    {
                        a = k + W1 + 1;
                        b++;
                        y = 0;
                        secondstring = true;
                    }
                    else
                    {
                        a++;
                        b++;
                    }
                }
                else
                {
                    if ((text1[a].ToString() != " ") && (text2[b].ToString() != " "))
                    {
                        if ((y == W2) || (result > 0 && secondstring == true))
                        {
                            result = 0;
                            y = 0;
                            for (int n = a; n > 0; n--)
                            {
                                if (text1[n].ToString() == " ")
                                {
                                    a = n + 1;
                                    break;
                                }
                            }
                            secondstring = false;
                            b = 0;
                        }
                        else
                        {
                            a++;
                        }
                    }
                    if (a < S1.Length) 
                    {
                        if (text1[a].ToString() == " ")
                            a++;
                    }
                    if (b < S2.Length)
                    {
                        if (text2[b].ToString() == " ")
                            b++;
                    }
                }
                if (a > H1 * W1 + (H1 - 1))
                    break;
            }

            if (result == H2 * W2)
                return true;
            else
                return false;
        }
    }
}
