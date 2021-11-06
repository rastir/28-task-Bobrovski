using System;
using System.Collections.Generic;

namespace Level1Space
{
    public static class Level1
    {
        public static bool SherlockValidString(string s)
        {
            if (String.IsNullOrEmpty(s))
                return false;

            Dictionary<char, int > pwd = new Dictionary<char, int>();

            for (int i = 0; i < s.Length; i++)
            {
                if (pwd.TryGetValue(s[i], out _))
                    pwd[s[i]]++;
                else
                {
                    pwd.Add(s[i], 1);
                }
            }

            int firstElement = pwd[s[0]];
            int number_of_meet = 0;

            foreach (var recordOfDictionary in pwd)
            {
                if (firstElement != recordOfDictionary.Value)
                    number_of_meet++;
            }

            if (number_of_meet == 0)
                return true;
            else if (number_of_meet > 1)
                return false;
            else
            {
                bool result = false;
                foreach (var recordOfDictionary in pwd)
                {
                    if (firstElement != recordOfDictionary.Value)
                    {
                        if (Math.Abs(number_of_meet - recordOfDictionary.Value) > 1)
                            return false;
                        else
                            result = true;
                    }
                    else
                        result = true;
                }
                return result;
            }
        }
    }
}
