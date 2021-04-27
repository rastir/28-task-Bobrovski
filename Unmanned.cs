using System;

namespace Level1Space
{
    public static class Level1
    {
        public static int Unmanned(int L, int N, int[][] track)
        {
            int ts = 0; 
            int tp = 0; 
            bool trafficLight = false; 
            bool trafficLightOutside = true;

            int[] temp = new int[3];

            if (track[0][0] <= L)
                trafficLightOutside = false;

            for (int m = 0; m < track.Length - 1; m++)
            {
                if (track[m][0] > track[m + 1][0])
                {
                    Array.Copy(track[m], temp, 3);
                    Array.Copy(track[m + 1], track[m], 3);
                    Array.Copy(temp, track[m + 1], 3);
                }
                if (track[m][0] <= L)
                    trafficLightOutside = false;
            }

            if (trafficLightOutside == false)
            {
                for (int m = 0; m < track.Length; m++)
                {
                    if (track[m][0] > L) 
                        break;
                    int differenceLight = 0; 
                    if (m > 0) 
                        differenceLight = track[m][0] - track[m - 1][0];
                    tp +=track[m][0] - tp + differenceLight; 
                    int summa = 0;

                    while (summa < tp) 
                    {
                        summa += track[m][1];
                        trafficLight = true;
                        if (summa >= tp)
                            break;
                        else
                        {
                            summa += track[m][2];
                            trafficLight = false;
                        }
                        if (summa >= tp)
                            break;
                    }

                    if (trafficLight == true) 
                    {
                        ts += summa - tp;
                        tp += summa - tp;
                        if (m + 1 == track.Length) 
                        {
                            tp += (L - tp); 
                        }
                    }
                    else if (trafficLight == false) 
                    {
                        if (m + 1 == track.Length)
                        {
                            tp += L - tp;
                        }
                    }
                }
                if (tp < L)
                    tp += L - tp;
                tp += ts;
                return tp;
            }
            else
                return L;
        }
    }
}
