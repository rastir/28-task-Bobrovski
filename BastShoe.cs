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
                    if (rrr.FindLast(t => t == t) != null && rrr.FindLast(t => t == t).command == 4) 
                    { 
                        rrr.Clear(); 
                    } 
                    Commands op = new Commands();
                    op.command = burr;
                    op.str = comanda;
                    rrr.Add(op);
                    S += comanda;

                    return S;

                case 2:
                    try
                    {
                    var second2 = Convert.ToInt16(comanda.Trim());
                    Commands op2 = new Commands();
                    op2.Undostr = S.Substring(S.Length - Math.Min(S.Length, second2));
                    S = S.Remove(S.Length - Math.Min(S.Length, second2));
                    if (rrr.FindLast(t => t == t) != null && rrr.FindLast(t => t == t).command == 4) 
                        { 
                            rrr.Clear(); 
                        }
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
                    Commands op3 = new Commands();
                    op3.command = burr;
                    op3.str = comanda;
                    rrr.Add(op3);
                    if (second3 > S.Length)
                        return "";
                    else
                        return S[second3].ToString();


                case 4:
                    {
                        var last4 = rrr.FindLast(t => t.isUndo == false && (t.command == 1 || t.command == 2));

                        if (last4 != null)
                        {
                            Commands op4 = new Commands();
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
                            op4.command = burr;
                            op4.Undocommand = last4.command;
                            last4.isUndo = true;
                            rrr.Add(op4);
                        }
                    }
                    return S;
                case 5:
                    var last5 = rrr.FindLast(t => t.isUndo == false && t.command == 4);
                    if (last5 != null)
                    {
                        Commands op5 = new Commands();
                        if (last5.Undocommand == 1) 
                        { 
                            S += last5.Undostr;
                            op5.Undocommand = 0;
                            op5.Undostr = "";
                            op5.command = 1;
                            op5.str= last5.Undostr;
                        }
                        if (last5.Undocommand == 2)
                        {
                            if (S.EndsWith(last5.str))
                                S.Substring(0, S.Length - last5.str.Length);
                            op5.Undocommand = 0;
                            op5.Undostr = "";
                            op5.command = 2;
                            op5.str = last5.Undostr;
                        }
                        last5.isUndo = true;
                        rrr.Add(op5);
                    }
                    return S;
            }
            return S;
        }
    }
}
