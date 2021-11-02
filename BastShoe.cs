using System;
using System.Collections.Generic;

namespace Level1Space
{
    public static class Level1
    {
        public static List<Commands> rrr = new List<Commands>();

        public class Commands
        {
            public int command = 0;
            public bool isUndo;
            public string str = "";
            public string str2 = "";
            public string Undostr = "";
            public int Undocommand = 0;
        }

        public static int Cursor = 0;
        public static bool LastCursor = false;
        public static string S = "";
        public static string comanda = "";

        public static string BastShoe(string command)
        {
            if (command == "")
                return S;

            char[] massiv = command.ToCharArray();
            int burr = Convert.ToInt32(command.Substring(0, 1));

            comanda = command.Length > 1 ? command.Substring(2) : "";

            if (burr != 1 && burr != 2 && burr != 3 && burr != 4 && burr != 5)
                return S;

            if ((burr == 1 || burr == 2 || burr == 3) && command.Length < 3)
                return S;

            if ((burr == 4 || burr == 5) && command.Length > 1)
                return S;

            switch (burr)
            {
                case 1:
                    Commands op = new Commands();
                    op.command = burr;
                    op.str = comanda;
                    rrr.Add(op);
                    S += comanda;
                    op.str2 = S;
                    int temp = Cursor;
                    Cursor = rrr.IndexOf(op);
                    if (LastCursor)
                    {
                        for (int i = Cursor - 1; i > -1; i--)
                        {
                            if (i != temp)
                                rrr.RemoveAt(i);
                        }
                        Cursor = rrr.Count - 1;
                    }
                    LastCursor = false;
                    return S;

                case 2:
                    var second2 = Convert.ToInt16(comanda.Trim());
                    Commands op2 = new Commands();
                    op2.Undostr = S.Substring(S.Length - Math.Min(S.Length, second2));
                    S = S.Remove(S.Length - Math.Min(S.Length, second2));
                    op2.str2 = S;                   
                    op2.command = burr;
                    op2.str = comanda;
                    rrr.Add(op2);
                    int temp2 = Cursor;
                    Cursor = rrr.IndexOf(op2);
                    if (LastCursor)
                    {
                            
                        for (int i = Cursor - 1; i > -1; i--)
                        {
                            if (i != temp2)
                            rrr.RemoveAt(i);
                        }
                        Cursor = rrr.Count - 1;
                    }
                    LastCursor = false;

                    return S;

                case 3:
                    LastCursor = false;
                    if (Convert.ToInt32(comanda) > S.Length)
                        return "";
                    else
                        return S[Convert.ToInt32(comanda)].ToString();

                case 4:
                    {
                        var last4 = rrr.FindLast(t => t.isUndo == false && (t.command == 1 || t.command == 2));

                        if (last4 != null)
                        {
                            LastCursor = true;

                            if (Cursor - 1 >= 0)
                                Cursor--;
                            S = rrr[Cursor].str2;
                        }
                    }
                    return S;
                case 5:
                    var last5 = rrr[Cursor]; 
                    if (last5 != null)
                    {
                        if (Cursor + 1 <= rrr.Count - 1 )
                            Cursor++;
                        S = rrr[Cursor].str2;
                        LastCursor = false;
                    }
                    return S;
            }
            return S;
        }
    }
}
