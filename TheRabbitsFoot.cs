using System;

namespace Level1Space
{
    public static class Level1
    {
        public static string TheRabbitsFoot(string s, bool encode)
        {
            if (encode == true)
            {
                s = s.Replace(" ", string.Empty);
                double root = Math.Sqrt(s.Length);
                int down = (int)Math.Floor(root);
                int up = (int)Math.Ceiling(root);
                if (down * up < s.Length)
                    down++;
                string[,] matrix = new string[up, down];
                int k = 0;
                for (int i = 0; i < up; i++)
                {
                    for (int j = 0; j < down; j++)
                    {
                        if (k < s.Length)
                        {
                            matrix[i, j] = s[k].ToString();
                            k++;
                            Console.Write(matrix[i, j]);
                        }
                        else
                            break;
                    }
                    Console.WriteLine();
                }
                int p = down * up;
                k = 0;
                string result = "";
                for (int i = 0; i < down; i++)
                {
                    for (int j = 0; j < up; j++)
                    {
                        if (k < p)
                        {
                            result += matrix[j, i];
                            k++;
                        }
                        else
                            break;
                    }
                    result += " ";
                }
                result = result.Trim();
                return result;
            }
            else
            {
                string s1 = s.Replace(" ", string.Empty);
                double root = Math.Sqrt(s1.Length);
                int down = (int)Math.Floor(root);
                int up = (int)Math.Ceiling(root);
                if (down * up < s1.Length)
                    down++;
                string[,] matrix = new string[up, down];
                int k = 0;
                s = s.Trim();
                char[] array = s.ToCharArray();
                for (int i = 0; i < up; i++)
                {
                    for (int j = 0; j < down; j++)
                    {
                        if (k < down * up) 
                        {
                            matrix[i, j] = array[k].ToString();
                            if ((array[k].ToString() == " ") && (j == down - 1))
                                break;
                            else if (array[k].ToString() == " ")
                            {
                                k++;
                                matrix[i, j] = array[k].ToString();
                            }
                            k++;
                        }
                        else
                            break;
                    }
                }
                k = 0;
                string result = "";
                for (int i = 0; i < down; i++)
                {
                    for (int j = 0; j < up; j++)
                    {
                        if (k < s.Length)
                        {
                            result += matrix[j, i];
                            k++;
                        }
                        else
                            break;
                    }
                }
                result = result.Trim();
                return result;
            }
        }
    }
}
