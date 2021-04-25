using System;

namespace Level1Space
{
    public static class Level1
    {
        public static int Unmanned(int L, int N, int[][] track)
        {
            int tabs = 0;
            int ts = 0;
            bool trafficLight = false;

            int[] temp = new int[3];
            for (int m = 0; m < track.Length - 1; m++)
            {
                if (track[m][0] > track[m + 1][0])
                {
                    Array.Copy(track[m], temp, 3);
                    Array.Copy(track[m + 1], track[m], 3);
                    Array.Copy(temp, track[m + 1], 3);
                }
            }

            for (int m = 0; m < track.Length; m++)
            {
                tabs = tabs + (track[m][0] - tabs) + ts;
                ts = 0;
                int summa = 0;

                while (summa < tabs)
                {
                    summa += track[m][1];
                    trafficLight = true;
                    if (summa >= tabs)
                        break;
                    else
                    {
                        summa += track[m][2];
                        trafficLight = false;
                    }
                    if (summa >= tabs)
                        break;
                }

                if (trafficLight == true)
                {
                    ts += summa - tabs; 
                    if (m + 1 == track.Length)
                    {
                        tabs += (L - tabs) + ts; 
                    }
                }
                else if (trafficLight == false) 
                {
                    if (m + 1 == track.Length) 
                    {
                        tabs += L - track[m][0];
                    }
                }
            }
            if (tabs < L)
                tabs += L - tabs;
            return tabs;
        }
    }
}
