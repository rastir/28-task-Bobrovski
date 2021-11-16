using System;
using System.Collections.Generic;

namespace Level1Space
{
    public static class Level1
    {
       public static void MatrixTurn(string[] Matrix, int M, int N, int T)
        {
            int[,] Array_Matrix = new int[M, N];
            int[,] Array_Matrix_Copy = new int[M, N];

            decimal number = 1;
            for (int i = 0; i < M; i++)
            {
                string word = Matrix[i];
                word.ToCharArray();

                for (int j = 0; j < N; j++)
                {
                    Array_Matrix[i, j] = Convert.ToInt32(word[j].ToString());
                }
            }

            while (number <= T)
            {
                int a = 0, b = 0, ind1 = M, ind2 = N;

                while (a <= Math.Floor((decimal)M / 2) - 1 && b <= Math.Floor((decimal)N / 2) - 1)
                {
                    ind1--;
                    ind2--;

                    for (int y = b + 1; y < N; y++)
                    {
                        if (number % 2 != 0)
                            Array_Matrix_Copy[a, y] = Array_Matrix[a, y - 1];
                        else
                            Array_Matrix[a, y] = Array_Matrix_Copy[a, y - 1];
                    }

                    int temp1 = a;
                    for (int x = a + 1; x <= ind1; x++)
                    {
                        if (number % 2 != 0)
                        {
                            Array_Matrix_Copy[x, ind2] = Array_Matrix[temp1, ind2];
                            if (temp1 < ind1 - 1)
                                temp1++;
                        }
                        else
                        {
                            Array_Matrix[x, ind2] = Array_Matrix_Copy[temp1, ind2];
                            if (temp1 < ind1 - 1)
                                temp1++;
                        }
                    }

                    int temp2 = ind2;
                    for (int y = ind2 - 1; y >= 0; y--)
                    {
                        if (number % 2 != 0)
                        {
                            Array_Matrix_Copy[ind1, y] = Array_Matrix[ind1, temp2];
                            if (temp2 > 0)
                                temp2--;
                        }
                        else
                        {
                            Array_Matrix[ind1, y] = Array_Matrix_Copy[ind1, temp2];
                            if (temp2 > 0)
                                temp2--;
                        }
                    }

                    int temp3 = M - 1;
                    for (int x = M - 2; x >= a; x--)
                    {
                        if (number % 2 != 0)
                        {
                            Array_Matrix_Copy[x, a] = Array_Matrix[temp3, a];
                            if (temp3 > 0)
                                temp3--;
                        }
                        else
                        {
                            Array_Matrix[x, a] = Array_Matrix_Copy[temp3, a];
                            if (temp3 > 0)
                                temp3--;
                        }
                    }
                    a++; b++;
                }
                number++;
            }

            Array.Clear(Matrix,0,Matrix.Length);
            for (int x = 0; x < M; x++)
            {
                for (int y = 0; y < N; y++)
                {
                    if (T % 2 != 0)
                        Matrix[x] += Array_Matrix_Copy[x, y];
                    else
                        Matrix[x] += Array_Matrix[x, y];
                }
            }
        } 
    }
}
