using System;

namespace Level1Space
{
    public static class Level1
    {
        public static string BigMinus(string s1, string s2)
        {
            char[] s11 = s1.ToCharArray();
            char[] s22 = s2.ToCharArray();
            bool Equal = false;
            if (s11.Length >= s22.Length)
            {
                int[] minus = new int[s11.Length];
                int i=0;
                for (int k = s11.Length - 1; k >= 0; k--)
                {
                    if (i != -1)
                    {
                        for (i = s22.Length - 1; i >= 0; i--)
                        {
                            if (Convert.ToInt32(s11[k]) != Convert.ToInt32(s22[i]) || (s11.Length != s22.Length))
                                Equal = true;
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
                if (Equal == false)
                    return "0";
                else
                {
                    string result = string.Join("", minus);
                    result = result.TrimStart('0');
                    return result;
                }
            }
            else
            {
                int[] minus = new int[s11.Length];
                for (int k = s22.Length - 1; k >= 0; k--)
                {
                    int i;
                    for (i = s11.Length - 1; i >= 0; i--)
                    {
                        if (Convert.ToInt32(s11[k]) != Convert.ToInt32(s22[i]) || (s11.Length != s22.Length))
                            Equal = true;
                        if (Convert.ToInt32(s22[k]) >= Convert.ToInt32(s11[i]))
                        {
                            minus[k] = Math.Abs(Convert.ToInt32(s22[k]) - Convert.ToInt32(s11[i]));
                            k--;
                        }
                        else
                        {
                            s22[k - 1] = Convert.ToChar(s22[k - 1] - 1);
                            s22[k] = Convert.ToChar(s22[k] + 10);
                            minus[k] = Math.Abs(Convert.ToInt32(s22[k]) - Convert.ToInt32(s11[i]));
                            k--;
                        }
                    }
                    if (i == 0 && k >= 0)
                        minus[k] = Convert.ToInt32(s22[k]);
                }
                if (Equal == false)
                    return "0";
                else
                {
                    string result = minus.ToString();
                    result = result.TrimStart('0');
                    return result;
                }
            }            
        }
    }
}
