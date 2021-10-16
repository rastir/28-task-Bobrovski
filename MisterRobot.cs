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
                while (!sorted)
                {
                    sorted = true;
                    for (int i = data.Length - 1; i > 0; i--)
                    {
                        if (data[i] > data[i - 1])
                            continue;
                        else
                        {
                            c = data[i];
                            b = data[i - 1];
                            a = data[i - 2];

                            while (!(c <= b && b <= a))
                            {
                                if (a < b) { tmp = a; a = b; b = tmp; }
                                if (a < c) { tmp = a; a = c; c = tmp; }
                                if (b < c) { tmp = b; b = c; c = tmp; }
                            }
                            data[i] = a;
                            data[i - 1] = b;
                            data[i - 2] = c;
                            sorted = false;
                        }
                    }
                }
                for (int i = 0; i < data.Length - 1; i++)
                {
                    if (data[i] > data[i + 1])
                    {
                        return false;
                    }
                }
                return true;
            }
        }
    }
}
