namespace Level1Space
{
    public static class Level1
    {
       public static bool MisterRobot(int N, int[] data)
        {
            if ((N != data.Length) || (N <= 4))
                return false;
            else
            {
                bool sorted = false;
                int tmp, a, b, c;

                DateTime StartTime = DateTime.UtcNow;
                DateTime EndTime;
                double differenceInSecond;

                TimeSpan diff;
                bool timeOver = false;

                while ((!sorted) || timeOver == true)
                {
                    sorted = true;

                    for (int i = data.Length - 1; i > 1; i--)
                    {
                        if (data[i] > data[i - 1])
                            continue;
                        else
                        {
                            a = data[i];
                            b = data[i - 1];
                            c = data[i - 2];

                            int count = 0;
                            while (!(c <= b && b <= a) || timeOver == true)
                            {
                                tmp = c;
                                c = b;
                                b = a;
                                a = tmp;

                                count++;
                                if (count == 3)
                                {
                                    while (!(b < a))
                                    {
                                        tmp = c;
                                        c = b;
                                        b = a;
                                        a = tmp;
                                    }
                                    break;
                                }

                                EndTime = DateTime.UtcNow;
                                diff = EndTime - StartTime;
                                differenceInSecond = diff.TotalSeconds;
                                if (differenceInSecond > 1)
                                {
                                    timeOver = true;
                                    sorted = false;
                                    break;
                                }
                                else
                                    continue;
                            }
                            if (timeOver == true)
                                break;
                            data[i] = a;
                            data[i - 1] = b;
                            data[i - 2] = c;
                            sorted = false;
                        }
                    }
                    for (int j = 0; j < data.Length - 1; j++)
                    {
                        if (data[j] > data[j + 1])
                        {
                            sorted = false;
                        }
                    }
                    EndTime = DateTime.UtcNow;
                    diff = EndTime - StartTime;
                    differenceInSecond = diff.TotalSeconds;
                    if (differenceInSecond > 1)
                    {
                        break;
                    }
                    else
                        continue;
                }
                if (sorted == true)
                    return true;
                else
                    return false;
            }
        }
    }
}
