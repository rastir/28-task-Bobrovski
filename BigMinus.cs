using System;

namespace Level1Space
{
    public static class Level1
    {
        public static string BigMinus(string s1, string s2)
        {
            char[] s11 = s1.ToCharArray();
            char[] s22 = s2.ToCharArray();
            int equal = 0; 
            if (s11.Length == s22.Length)
            {
                for (int k = 0; k < s11.Length; k++)
                {
                    for (int i = 0; i < s22.Length; i++)
                    {
                        if (Convert.ToInt32(s11[k]) > Convert.ToInt32(s22[i]))
                        {
                            equal = 1;
                            break;
                        }
                        else if (Convert.ToInt32(s11[k]) < Convert.ToInt32(s22[i]))
                        {
                            equal = 3;
                            break;
                        }
                        else if (Convert.ToInt32(s11[k]) == Convert.ToInt32(s22[i]))
                        {
                            if (k == s11.Length - 1)
                                equal = 2;
                            else
                                k++;
                        }
                    }
                    if (equal != 0)
                        break;
                }
            }
            else if (s11.Length > s22.Length)
                equal = 1;
            else if (s11.Length < s22.Length)
                equal = 3;
            if (equal == 2)
                return "0";
            else if (equal == 1)
            {
                int[] minus = new int[s11.Length];
                int i = 0;
                for (int k = s11.Length - 1; k >= 0; k--)
                {
                    if (i != -1)
                    {
                        for (i = s22.Length - 1; i >= 0; i--)
                        {
                            if (Convert.ToInt32(s11[k]) >= Convert.ToInt32(s22[i]))
                            {
                                minus[k] = Math.Abs(Convert.ToInt32(s11[k].ToString()) - Convert.ToInt32(s22[i].ToString()));
                                k--;
                            }
                            else
                            {
                                s11[k - 1] = Convert.ToChar(s11[k - 1] - 1);
                                s11[k] = Convert.ToChar(s11[k] + 10);
                                minus[k] = Math.Abs(Convert.ToInt32(s11[k]) - Convert.ToInt32(s22[i]));
                                k--;
                            }
                        }
                    }
                    if (i == -1 && k >= 0)
                    {
                        minus[k] = Convert.ToInt32(s11[k].ToString());
                    }
                }
                string result = string.Join("", minus);
                result = result.TrimStart('0');
                return result;
            }
            else if (equal == 3)
            {
                int[] minus = new int[s11.Length];
                for (int k = s22.Length - 1; k >= 0; k--)
                {
                    int i;
                    for (i = s11.Length - 1; i >= 0; i--)
                    {
                        if (Convert.ToInt32(s22[k]) >= Convert.ToInt32(s11[i]))
                        {
                            minus[k] = Math.Abs(Convert.ToInt32(s22[k]) - Convert.ToInt32(s11[i]));
                            if (k > 0)
                                k--;
                            else
                                break;
                        }
                        else
                        {
                            s22[k - 1] = Convert.ToChar(s22[k - 1] - 1);
                            s22[k] = Convert.ToChar(s22[k] + 10);
                            minus[k] = Math.Abs(Convert.ToInt32(s22[k]) - Convert.ToInt32(s11[i]));
                            k--;
                        }
                    }
                }
                string result = string.Join("", minus);
                result = result.TrimStart('0');
                return result;
            }
            else
                return "0";
        }
    }
}
