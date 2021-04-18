using System;

namespace Level1Space
{
    public static class Level1
    {
        public static string MassVote(int N, int[] Votes)
        {
            int max = Votes[0];
            int x=0;
            for (int i = 0; i < Votes.Length; i++) 
            {
                if (Votes[i] > max)
                {
                    max = Votes[i];
                    x = i;
                }
            }
            x++;
            int k = 0;
            for (int i = 0; i < Votes.Length; i++) 
            {
                if (Votes[i] == max)
                    k++;  
            }
            if (k > 1)
                return "no winner";
            else
            {
                int summ = 0;
                for (int i=0; i < Votes.Length; i++)
                {
                    summ += Votes[i];
                }
                decimal summ2 = 100 * max / summ;
                summ2 = Math.Round(summ2, 3);
                if (summ2 > 50)
                    return $"majority winner {x}";
                else
                    return $"minority winner {x}";
            }
        }
    }
}
