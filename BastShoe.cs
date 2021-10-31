using System;
using System.Collections.Generic;

namespace Level1Space
{
    public static class Level1
    {
        public static List<commands> rrr = new List<commands>();

        public class commands {
            public int command = 0;
            public bool isUndo;
            public string str = "";
            public string Undostr = "";
            public int Undocommand = 0;

        }

        public static string S = "";//текущая строка
        public static string comanda = "";//текущая команда

        public static string BastShoe(string command)
        {
            if (command == "") return S;
            char[] massiv = command.ToCharArray();
            int burr = Convert.ToInt32(command.Substring(0, 1));

            comanda = command.Length > 1 ? command.Substring(2) : "";

            switch (burr)
            {
                case 1:
                    if (rrr.FindLast(t => t == t) != null && rrr.FindLast(t => t == t).command == 4) { rrr.Clear(); rrr = new List<commands>(); } //rrr = new List<commands>(); }
                    commands op = new commands();
                    op.command = burr;
                    op.str = comanda;
                    rrr.Add(op);
                    S += comanda;

                    return S;

                case 2:
                    try
                    {
                        var second2 = Convert.ToInt16(comanda.Trim());
                        commands op2 = new commands();
                        op2.Undostr = S.Substring(S.Length - Math.Min(S.Length, second2));
                        S = S.Remove(S.Length - Math.Min(S.Length, second2));
                        if (rrr.FindLast(t => t == t) != null && rrr.FindLast(t => t == t).command == 4) { rrr.Clear(); rrr = new List<commands>(); }// rrr = new List<commands>(); }
                        op2.command = burr;
                        op2.str = comanda;
                        rrr.Add(op2);
                    }
                    catch (Exception)
                    {

                        throw;
                    }
                    return S;

                case 3:
                    string[] words3 = command.Split(" ");
                    int second3 = Convert.ToInt32(words3[1]);
                    if (second3 > S.Length)
                        return "";
                    else
                        return S[second3].ToString();

                case 4:
                    {
                        var last4 = rrr.FindLast(t => t.isUndo == false /*&& t.str==""*/ && (t.command == 1 || t.command == 2));
                        if (last4 != null)
                        {
                            commands op4 = new commands();
                            if (last4.command == 1)
                            {
                                if (S.EndsWith(last4.str))
                                    S = S.Substring(0, S.Length - last4.str.Length);
                            }
                            if (last4.command == 2)
                            {
                                S += last4.Undostr;
                            }
                            op4.Undostr = last4.str;
                            op4.Undocommand = last4.command;
                            last4.isUndo = true;

                        }
                    }
                    return S;       
                case 5:
                    var last5 = rrr.FindLast(t => t.isUndo == false && t.command == 4);
                    if (last5 != null) 
                    {
                        if (last5.Undocommand == 1) { S += last5.Undostr; }
                        if (last5.Undocommand == 2) {
                            if (S.EndsWith(last5.str))
                                S.Substring(0, S.Length - last5.str.Length);
                        }
                        last5.isUndo = true;
                    }
                    return S;
            }
            return S;
        }
    }
}
