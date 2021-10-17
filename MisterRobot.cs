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
                    Random rnd = new Random();
                    sorted = true;
                    int i = rnd.Next(0, data.Length - 1);
                    if ((i + 2) > (data.Length - 1))
                        i = data.Length - 3;

                    a = data[i];
                    b = data[i + 1];
                    c = data[i + 2];

                    int count = 0;
                    while (!(a <= b && b <= c) || timeOver == true || count == 3)
                    {
                        tmp = a; 
                        a = b; 
                        b = c; 
                        c = tmp;

                        count++;
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
                    data[i + 1] = b;
                    data[i + 2] = c;

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
                        timeOver = true;
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
