namespace Level1Space
{
    public static class Level1
    {
        public static int MaximumDiscount(int N, int[] Price)
        {
            if (Price.Length != N)
            {
                return 0;
            }
            else
            {
                for (int i = 0; i < Price.Length; i++)
                {                    
                    for (int j = 0; j < Price.Length - 1 - i; j++)
                    {
                        if (Price[j] < Price[j + 1])
                        {
                            int tmpParam = Price[j];
                            Price[j] = Price[j + 1];
                            Price[j + 1] = tmpParam;
                        }
                    }
                }
                int summ = 0; 
                for (int i = 0; i < Price.Length; i++)
                {
                    if ((i + 1) % 3 == 0)
                    {
                        summ += Price[i];
                    }
                }
                return summ;
            }
        }
    }
}
