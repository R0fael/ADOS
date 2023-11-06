using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADOS
{
    public static class Asci
    {
        #region symbols
        public static string[] A = {"@@@@",
                             "@  @",
                             "@@@@",
                             "@  @",
                             "@  @",};

        public static string[] B = {"@@@ ",
                             "@  @",
                             "@@@@",
                             "@  @",
                             "@@@ ",};

        public static string[] C = {" @@@",
                             "@   ",
                             "@   ",
                             "@   ",
                             " @@@",};

        public static string[] D = {"@@@ ",
                             "@  @",
                             "@  @",
                             "@  @",
                             "@@@ ",};

        public static string[] E = {"@@@@",
                             "@   ",
                             "@@@@",
                             "@   ",
                             "@@@@",};

        public static string[] F = {"@@@@",
                             "@   ",
                             "@@@@",
                             "@   ",
                             "@   ",};

        public static string[] G = {" @@@",
                             "@   ",
                             "@ @@",
                             "@  @",
                             " @@@",};

        public static string[] H = {"@  @",
                             "@  @",
                             "@@@@",
                             "@  @",
                             "@  @",};

        public static string[] I = {"@@@@",
                             " @@ ",
                             " @@ ",
                             " @@",
                             "@@@@",};

        public static string[] J = {"@@@@",
                             " @@ ",
                             " @@ ",
                             " @@ ",
                             "@@  ",};

        public static string[] K = {"@  @",
                             "@ @ ",
                             "@@  ",
                             "@ @ ",
                             "@  @",};

        public static string[] L = {"@   ",
                             "@   ",
                             "@   ",
                             "@   ",
                             "@@@@",};

        public static string[] M = {" @@ @@ ",
                             "@  @  @",
                             "@  @  @",
                             "@  @  @",
                             "@  @  @",};

        public static string[] N = {" @@ ",
                             "@  @",
                             "@  @",
                             "@  @",
                             "@  @",};

        public static string[] O = {"@@@@",
                             "@  @",
                             "@  @",
                             "@  @",
                             "@@@@",};

        public static string[] P = {"@@@ ",
                             "@  @",
                             "@@@ ",
                             "@   ",
                             "@   ",};

        public static string[] Q = {"@@@@",
                             "@  @",
                             "@  @",
                             "@@@@",
                             "   @",};

        public static string[] R = {"@@@@",
                             "@  @",
                             "@@@@",
                             "@@  ",
                             "@ @ ",};

        public static string[] S = {" @@@",
                             "@   ",
                             " @@@",
                             "   @",
                             "@@@ ",};

        public static string[] T = {"@@@@",
                             " @@ ",
                             " @@ ",
                             " @@ ",
                             " @@ ",};

        public static string[] U = {"@  @",
                             "@  @",
                             "@  @",
                             "@  @",
                             "@@@@",};

        public static string[] V = {"@  @",
                             "@  @",
                             "@  @",
                             "@  @",
                             " @@ ",};

        public static string[] W = {"@  @  @",
                             "@  @  @",
                             "@  @  @",
                             "@  @  @",
                             " @@@@@",};

        public static string[] X = {"@  @",
                             " @@ ",
                             " @@ ",
                             " @@ ",
                             "@  @",};

        public static string[] Y = {"@  @",
                             "@  @",
                             " @@ ",
                             " @@",
                             " @@",};

        public static string[] Z = {"@@@@",
                             "   @",
                             "  @ ",
                             " @  ",
                             "@@@@",};

        public static string[] plus = {" @@ ",
                                " @@ ",
                                "@@@@",
                                " @@ ",
                                " @@ ",};

        public static string[] minus = {"    ",
                                 "    ",
                                 "@@@@",
                                 "    ",
                                 "    ",};

        public static string[] space = {"    ",
                                 "    ",
                                 "    ",
                                 "    ",
                                 "    ",};

        public static string[] full = {"@@@@",
                                "@@@@",
                                "@@@@",
                                "@@@@",
                                "@@@@",};

        public static string[] space_between_symbols = {"  ",
                                "  ",
                                "  ",
                                "  ",
                                "  ",};
        #endregion
        public static string[] Symbol(char sym)
        {
            return sym switch
            {
                'A' => A,
                'B' => B,
                'C' => C,
                'D' => D,
                'E' => E,
                'F' => F,
                'G' => G,
                'H' => H,
                'I' => I,
                'J' => J,
                'K' => K,
                'L' => L,
                'M' => M,
                'N' => N,
                'O' => O,
                'P' => P,
                'Q' => Q,
                'R' => R,
                'S' => S,
                'T' => T,
                'U' => U,
                'V' => V,
                'W' => W,
                'X' => X,
                'Y' => Y,
                'Z' => Z,
                '-' => minus,
                '+' => plus,
                ' ' => space,
                _ => minus,
            };
        }

        public static string[] Text(string txt)
        {

            string[] reg = { "", "", "", "", "" };
            string[] load;
            foreach (char s in txt)
            {
                load = Symbol(s);
                reg[0] += load[0] + "  ";
                reg[1] += load[1] + "  ";
                reg[2] += load[2] + "  ";
                reg[3] += load[3] + "  ";
                reg[4] += load[4] + "  ";
            }
            return reg;
        }

        public static void Print_asci(string[] txt)
        {
            Console.WriteLine(txt[0]);
            Console.WriteLine(txt[1]);
            Console.WriteLine(txt[2]);
            Console.WriteLine(txt[3]);
            Console.WriteLine(txt[4]);
        }

        public static void print(string txt)
        {
            Print_asci(Text(txt));
        }
    }
}
