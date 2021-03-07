using System;

namespace Level1Space
{
    public static class Level1
    {
        public static int[] WordSearch(int len, string s, string subs)
        {
            char[] s1 = s.ToCharArray();
            string[,] s3 = new string[len, len];
            int k = 0;
            int i;
            int j = 0;
            for (i = 0; i < len; i++)
            {
                bool twelve = false;
                for (j = 0; j < len; j++)
                {
                    if (k < s.Length)
                    {
                        if (s1[k].ToString() == " ")
                            twelve = true;
                        if (((j == 0) && (s1[k].ToString() == " ")) || ((s1[k].ToString() == " ") && (s1[k + 1].ToString() == " ")))
                        {
                            if (k == s.Length - 1)
                                break;
                            else
                            {
                                k++;
                                s3[i, j] = s1[k].ToString();
                            }
                        }
                        else
                            s3[i, j] = s1[k].ToString();
                        if (k == s.Length - 1)
                            break;
                        else
                            k++;
                    }
                }
                if (k == s.Length - 1)
                    break;
                else
                    if ((s[k].ToString() != " ") && (s[k - 1].ToString() != " "))
                {
                    int z = k;
                    for (int d = j - 1; d >= 0; d--)
                    {
                        if (s3[i, d].ToString() == " ")
                        {
                            break;
                        }
                        else if ((d == 0) && (s3[i, d].ToString() != " "))
                            k = z;
                        else
                        {
                            if (twelve == true)
                                s3[i, d] = "";
                            k--;
                        }
                    }
                }
            }
            string[] s4 = new string[len];
            bool w = false;
            int a, g;
            for (a = 0; a < len; a++)
            {
                for (g = 0; g < len; g++)
                {
                    if (s3[a, g] != null)
                    {
                        s4[a] += s3[a, g];
                    }
                    else
                    {
                        w = true;
                        Array.Resize(ref s4, a + 1);
                        break;
                    }
                }
                if (w == true)
                {
                    a++;
                    break;
                }
            }
            int[] result = new int[a];
            for (int c = 0; c < a; c++)
            {
                string values = s4[c].ToString();
                string subs3 = subs.Substring(0, 1);
                if (values.Contains(subs))
                {
                    for (int m = 0; m < a; m++)
                    {
                        if (m == 0)
                        {
                            if ((s3[c, m] == subs3) && ((s3[c, m + subs.Length] == " ") || s3[c, m + subs.Length] == null))
                            {
                                result[c] = 1;
                                break;
                            }
                        }
                        else if (m != 0)
                        {
                            if ((s3[c, m] == subs3) && (s3[c, m - 1] == " ") && ((s3[c, m + subs.Length] == " ") || s3[c, m + subs.Length] == null))
                            {
                                result[c] = 1;
                                break;
                            }
                        }
                        else
                            result[c] = 0;
                    }
                }
                else
                    result[c] = 0;
            }
            return result;
        }
    }
}
