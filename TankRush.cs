namespace Level1Space
{
    public static class Level1
    {
        public static bool TankRush(int H1, int W1, string S1, int H2, int W2, string S2)
        {
            if ((H2 <= H1) && (W2 <= W1))
            {
                char[] Array1 = S1.ToCharArray();
                char[] Array2 = S2.ToCharArray();

                int IndexFirst1;

                int IndexOf1 = 0;
                int IndexOf2 = 0;
                
                int IndexOfEnd1 = W1;
                int IndexOfEnd2 = W2;

                int ArrayRange2 = 0;
                int ArrayRange1 = 0;

                bool bryak = false; 
                bool contains2 = false;
                int difference = 0;

                bool dontgrowI = true;
                int i = 0, j = 0;

                while (i < H1) 
                {
                    while (j < H2) 
                    {
                        if ((i != 0) && (dontgrowI == true))
                        {
                            dontgrowI = true;
                            IndexOf1 += W1 + 1; 
                            IndexOfEnd1 = IndexOf1 + W1; 
                        }
                        if (j != 0)
                        {
                            IndexOf2 += W2 + 1; 
                            IndexOfEnd2 = IndexOf2 + W2; 
                        }

                        string number1 = "";
                        for (int x = IndexOf1 + difference; x < IndexOfEnd1; x++) 
                        {
                            number1 += Array1[x].ToString();
                        }

                        string number2 = "";
                        for (int y = IndexOf2; y < IndexOfEnd2; y++) 
                        {
                            number2 += Array2[y].ToString();
                        }

                        if (number1.Contains(number2)) 
                        {
                            if ((i > 0) && (Array1[IndexOf1 + difference] != Array2[IndexOf2]) && (ArrayRange2 != 0) && (ArrayRange1 == H1 - 1)) 
                            {
                                bryak = true;
                                break;
                            }
                            i++;
                            j++;
                            dontgrowI = true;

                            if (ArrayRange2 == H2 - 1) 
                            {
                                contains2 = true;
                                break;
                            }

                            if (ArrayRange1 == H1 - 1) 
                            {
                                bryak = true;
                                break;
                            }

                            ArrayRange1++;
                            ArrayRange2++;

                            for (int b = IndexOf1; b < IndexOfEnd1; b++)
                            {
                                if (Array2[IndexOf2] == Array1[b])
                                {
                                    IndexFirst1 = b;
                                    if (ArrayRange2 == 1)
                                        difference = IndexFirst1 - IndexOf1;
                                    break;
                                }
                            }
                        }
                        else
                        {
                            if (ArrayRange1 == H1 - 1) 
                            {
                                bryak = true;
                                break;
                            }
                            IndexOf2 = 0;
                            if (ArrayRange2 == 0)
                            {
                                dontgrowI = true;
                                i++;
                                ArrayRange1++;
                            }
                            j = 0;

                            if (ArrayRange2 != 0)
                            {
                                contains2 = false;
                                difference = 0;
                                IndexOfEnd2 = W2;
                                ArrayRange2 = 0;
                                if (ArrayRange1 < H1 - 1)
                                    dontgrowI = false;
                                else
                                    dontgrowI = true;
                            }
                        }
                    }
                    if ((contains2 == true) || (bryak == true))
                        break;
                }
                if ((contains2 == true) && (bryak != true))
                    return true;
                else
                    return false;
                #endregion
            }
            else
                return false;
        }
    }
}
