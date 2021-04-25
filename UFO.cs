using System;

namespace Level1Space
{
    public static class Level1
    {
                public static int[] UFO(int N, int[] data, bool octal)
        {
            int notation;
            if (octal == true)
                notation = 8;
            else
                notation = 16;
            string[] stringData = new string[N];
            int counter = 0;
            int[] result = new int[N];

            for (int i = 0; i < N; i++)
            {
                stringData[counter] = data[i].ToString();
                char[] charArray = stringData[counter].ToCharArray();
                int k = 0;

                for (int j = charArray.Length - 1; j > -1; j--)
                {
                    int numeral = int.Parse(charArray[j].ToString());
                    result[i] += (int)(numeral * Math.Pow(notation, k));
                    k++;
                }
            }
            return result;
        }
    }
}
