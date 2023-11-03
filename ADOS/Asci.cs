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

        public static   string[] T = {"@@@@",
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
        public static string[] symbol(char sym)
        {
            switch (sym)
            {
                default:
                    return minus;
                case 'A':
                    return A;
                case 'B':
                    return B;
                case 'C':
                    return C;
                case 'D':
                    return D;
                case 'E':
                    return E;
                case 'F':
                    return F;
                case 'G':
                    return G;
                case 'H':
                    return H;
                case 'I':
                    return I;
                case 'J':
                    return J;
                case 'K':
                    return K;
                case 'L':
                    return L;
                case 'M':
                    return M;
                case 'N':
                    return N;
                case 'O':
                    return O;
                case 'P':
                    return P;
                case 'Q':
                    return Q;
                case 'R':
                    return R;
                case 'S':
                    return S;
                case 'T':
                    return T;
                case 'U':
                    return U;
                case 'V':
                    return V;
                case 'W':
                    return W;
                case 'X':
                    return X;
                case 'Y':
                    return Y;
                case 'Z':
                    return Z;
                case '-':
                    return minus;
                case '+':
                    return plus;
                case ' ':
                    return space;
            }
        }

        public static string[] text(string txt)
        {

            string[] reg = {"","","","",""};
            string[] load;
            foreach (char s in txt)
            {
                load = symbol(s);
                reg[0] +=load[0] + "  ";
                reg[1] += load[1] + "  ";
                reg[2] += load[2] + "  ";
                reg[3] += load[3] + "  ";
                reg[4] += load[4] + "  ";
            }
            return reg;
        }

        public static void print_asci(string[] txt) 
        {
            Console.WriteLine(txt[0]);
            Console.WriteLine(txt[1]);
            Console.WriteLine(txt[2]);
            Console.WriteLine(txt[3]);
            Console.WriteLine(txt[4]);
        }

        public static void print(string txt)
        {
            print_asci(text(txt));
        }
    }
}
