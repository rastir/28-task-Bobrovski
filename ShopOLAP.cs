using System;

namespace Level1Space
{
    public static class Level1
    {
               public static string[] ShopOLAP(int N, string[] items)
        {
            string[] subs1;
            string[] subs2;

            string[] array1 = new string[items.Length];
            string[] array2 = new string[items.Length];
            int sum;

            for (int i = 0; i < items.Length - 1; i++)
            {
                string str1 = items[i].ToString();
                subs1 = str1.Split();
                array1[i] = subs1[0];
                array1[i + 1] = subs1[1];
                sum = Convert.ToInt32(array1[i + 1]);

                for (int x = 0; x < items.Length - 1; x++)
                {
                    if (i != x)
                    {
                        string str2 = items[x].ToString();
                        subs2 = str2.Split();
                        array2[x] = subs2[0];
                        array2[x + 1] = subs2[1];

                        if (array1[i].CompareTo(array2[x]) == 0)
                        {
                            sum += Convert.ToInt32(array2[x + 1]);
                            items[i] = string.Join(" ", array1[i], sum);

                            for (int j = x; j < items.Length - 1; j++)
                            {
                                items[j] = items[j + 1];
                            }

                            x--;
                            Array.Resize(ref items, items.Length - 1);
                        }
                    }
                }
            }

            string[] arr1 = new string[items.Length];
            string[] sub1;
            string[] arr2 = new string[items.Length];
            string[] sub2;
            bool sort = false;

            while (sort == false)
            {
                sort = true;
                for (int y = 0; y < items.Length - 1; y++)
                {
                    string str1 = items[y].ToString();
                    string str2 = items[y + 1].ToString();

                    sub1 = str1.Split();
                    sub2 = str2.Split();

                    string word1 = sub1[0];
                    string word2 = sub2[0];

                    arr1[y + 1] = sub1[1];
                    arr2[y + 1] = sub2[1];

                    if (Convert.ToInt32(arr1[y + 1]).CompareTo(Convert.ToInt32(arr2[y + 1])) == 0)
                    {
                        if (word1.CompareTo(word2) == 1)
                        {
                            string temp = items[y + 1];
                            items[y + 1] = items[y];
                            items[y] = temp;
                            sort = false;
                        }
                    }
                    else if (Convert.ToInt32(arr1[y + 1]).CompareTo(Convert.ToInt32(arr2[y + 1])) == -1)
                    {
                        string temp = items[y];
                        items[y] = items[y + 1];
                        items[y + 1] = temp;
                        sort = false;
                    }
                }
            }
            return items;
        }
    }
}
