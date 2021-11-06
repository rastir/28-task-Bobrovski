using System;
using System.Collections.Generic;

namespace Level1Space
{
    public static class Level1
    {
        public static string BiggerGreater(string input)
        {
            List<string> arr = new List<string>();
            if (String.IsNullOrEmpty(input)) 
                return "";

            for (int i = 0; i < input.Length - 1; i++)
            {
                if (input[i].ToString() == " ")
                    return "";
                if ((i + 1) >= input.Length)
                    break;
                
                for (int a = 1; a < input.Length; a++)
                {
                    if (input[i].ToString() == " ")
                        return "";
                    if ((i + a) >= input.Length)
                        break;

                    char[] word = input.ToCharArray();
                    char temp = word[i];

                    word[i] = word[i + a];
                    word[i + a] = temp;

                    string str1 = input.Substring(0, i + a);
                    string str2 = "";

                    for (int c = 0; c < str1.Length; c++)
                    {
                        str2 += word[c];
                    }

                    if (str1.CompareTo(str2) == -1)
                    {
                        string worrd = "";
                        for (int j = 0; j < word.Length; j++)
                        {
                            worrd += word[j];
                        }

                        if (!arr.Contains(worrd))
                            arr.Add(worrd);

                        int b;
                        string word_copy = worrd;
                        char[] array;
                        char[] array2 = word_copy.ToCharArray();

                        for (b = i + 1; b < word_copy.Length; b++)
                        {
                            if (word_copy[b].ToString() == " ")
                                return "";

                            for (int f = b; f < word_copy.Length; f++)
                            {
                                if (word_copy[f].ToString() == " ")
                                    return "";
                                if ((f + 1) >= word_copy.Length)
                                    break;
                                
                                array = word_copy.ToCharArray();

                                char temp2 = array[b];
                                array[b] = array[f + 1];
                                array[f + 1] = temp2;

                                worrd = "";
                                for (int x = 0; x < array.Length; x++)
                                {
                                    worrd += array[x];
                                }
                                if (!arr.Contains(worrd))
                                    arr.Add(worrd.ToString());
                            }
                        }
                    }
                }
            }
            if (arr.Count > 0)
            {
                arr.Sort();
                return arr[0];
            }
            else
                return "";
        }
    }
}
