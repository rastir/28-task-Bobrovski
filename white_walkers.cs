using System;
using System.Collections.Generic;

namespace Level1Space
{
    public static class Level1
    {
        public static bool white_walkers(string village)
        {
            if (String.IsNullOrEmpty(village) || village.Length < 5)
                return false;
            else
            {
                bool walkersAvailable = false;
                List<int> numbers = new List<int>() { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

                int firstNumber = 0;
                int firstIndex = 0;

                for (int i = 0; i < village.Length - 1; i++)
                {
                    if (numbers.Contains((int)char.GetNumericValue(village[i])))
                    {
                        if (firstNumber == 0)
                        {
                            firstNumber = Convert.ToInt16(char.GetNumericValue(village[i]));
                            firstIndex = i;
                        }
                        int j;
                        int countNumbersOfEqual = 0;
                        for (j = i + 1; j < village.Length; j++)
                        {
                            if (village[j] == '=')
                                countNumbersOfEqual++;
                            if (numbers.Contains((int)char.GetNumericValue(village[j])))
                            {
                                if (firstNumber + (int)char.GetNumericValue(village[j]) == 10)
                                {
                                    if (countNumbersOfEqual == 3)
                                        walkersAvailable = true;
                                    else
                                        walkersAvailable = false;
                                }
                                break;
                            }
                        }

                        i += (j - firstIndex - 1);
                        firstNumber = 0;
                    }
                }
                if (walkersAvailable == true)
                    return true;
                else
                    return false;
            }
        }
    }
}
