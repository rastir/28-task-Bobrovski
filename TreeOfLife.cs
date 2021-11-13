using System;
using System.Collections.Generic;

namespace Level1Space
{
    public static class Level1
    {
        public static string[] TreeOfLife(int H, int W, int N, string[] tree)
        {
            int[,] Array_tree = new int[H, W];
            int number = 1;
            for (int i = 0; i < H; i++) 
            {
                string word = tree[i];
                word.ToCharArray();

                for (int j = 0; j < W; j++)
                {
                    if (word[j].ToString() == ".")
                        Array_tree[i, j] = 0;
                    if (word[j].ToString() == "+")
                        Array_tree[i, j] = 1;
                }
            }

            while (number <= N)
            {
                number++;

                for (int i = 0; i < H; i++)
                {
                    for (int j = 0; j < W; j++)
                    {
                        Array_tree[i, j]++;
                    }
                }

                if (number % 2 != 0)
                {
                    for (int i = 0; i < H; i++)
                    {
                        for (int j = 0; j < W; j++)
                        {
                            if (Array_tree[i, j] >= 3)
                            {
                                Array_tree[i, j] = 0;
                                if (i > 0 && Array_tree[i - 1, j] < 3)
                                    Array_tree[i - 1, j] = 0; ;
                                if (i < H - 1 && Array_tree[i + 1, j] < 3)
                                    Array_tree[i + 1, j] = 0;
                                if (j > 0 && Array_tree[i, j - 1] < 3)
                                    Array_tree[i, j - 1] = 0;
                                if (j < W - 1 && Array_tree[i, j + 1] < 3)
                                    Array_tree[i, j + 1] = 0;
                            }
                        }
                    }
                }
            }

            string[] tree_result = new string[H];

            for (int i = 0; i < H; i++) 
            {
                for (int j = 0; j < W; j++)
                {
                    if (Array_tree[i, j] == 0)
                        tree_result[i] += ".";
                    if (Array_tree[i, j] > 0)
                        tree_result[i] += "+";
                }
            }

            return tree_result;
        }
    }
}
