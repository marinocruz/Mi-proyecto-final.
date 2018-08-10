using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor
{
    class Program
    {
        static void Main(string[] args)
        {
            int NUM1 = 0;
            string RESUL = null;
            string cadena;
            string op;

            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Marino De La Cruz");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("17-MIIN_1-042");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine("Seccion  0463");
            Console.WriteLine("----------------------------------------------------------");
            Console.WriteLine(" Elija la opcion 1) sistema binario  2)sistema octal  3)sistema hexadecimal");
            op = Console.ReadLine();
            

            switch (op)
            {
                case "1":
                    Program ob = new Program();
                    Console.Write("DIGITE NÚMERO : ");
                    cadena = Console.ReadLine();
                    NUM1 = int.Parse(cadena);
                    RESUL = ob.BINARIO(NUM1);
                    break;
                case "2":
                    Program obj = new Program();
                    Console.Write("DIGITE NÚMERO : ");
                    cadena = Console.ReadLine();
                    NUM1 = int.Parse(cadena);
                    RESUL = obj.OCTAL(NUM1);
                    break;
                case "3":
                    Program objs = new Program();
                    Console.Write("DIGITE NÚMERO : ");
                    cadena = Console.ReadLine();
                    NUM1 = int.Parse(cadena);
                    objs.HEXADECIMAL(NUM1);
                    break;
                default:
                    Console.WriteLine("No escogio ninguna Opcion!!!!!");
                break;
            }
            
            Console.WriteLine();
            Console.WriteLine("RESULTADO ES: " + RESUL);
            Console.Write("Pulse una Tecla:");
            Console.ReadLine();
        }

        private string BINARIO(int NUM)
        {
            int K = 0;
            int AUX = 0;
            string R = null;
            string BIN = null;
            R = "";
            while ((NUM >= 2))
            {
                AUX = NUM % 2;
                R = R + AUX.ToString();
                NUM = NUM / 2;
            }
            R = R + NUM.ToString();
            BIN = "";
            for (K = R.Length; K >= 1; K += -1)
            {
                BIN = BIN + R.Substring(K - 1, 1);
            }
            return BIN;
        }

        private string OCTAL(int NUM)
        {
            int K = 0;
            int AUX = 0;
            string R = null;
            string OCT = null;
            R = "";
            while ((NUM >= 8))
            {
                AUX = NUM % 8;
                R = R + AUX.ToString();
                NUM = NUM / 8;
            }
            R = R + NUM.ToString();
            OCT = "";
            for (K = R.Length; K >= 1; K += -1)
            {
                OCT = OCT + R.Substring(K - 1, 1);
            }
            return OCT;
        }

        private void HEXADECIMAL(int NUM)
        {
            int K = 0;
            int AUX = 0;
            string DAT;
            string R = null;
            string[] VEC = new string[21];
            int POS = 0;
            R = "";
            POS = 1;
            while ((NUM >= 16))
            {
                AUX = NUM % 16;
                R = R + AUX.ToString();
                switch (AUX)
                {
                    case 10:
                        DAT = "A";
                        break;
                    case 11:
                        DAT = "B";
                        break;
                    case 12:
                        DAT = "C";
                        break;
                    case 13:
                        DAT = "D";
                        break;
                    case 14:
                        DAT = "E";
                        break;
                    case 15:
                        DAT = "F";
                        break;
                    default:
                        DAT = AUX.ToString();
                        break;
                }
                VEC[POS] = DAT;
                POS = POS + 1;
                NUM = NUM / 16;
            }
            switch (NUM)
            {
                case 10:
                    DAT = "A";
                    break;
                case 11:
                    DAT = "B";
                    break;
                case 12:
                    DAT = "C";
                    break;
                case 13:
                    DAT = "D";
                    break;
                case 14:
                    DAT = "E";
                    break;
                case 15:
                    DAT = "F";
                    break;
                default:
                    DAT = Convert.ToString(NUM);
                    break;
            }

            VEC[POS] = DAT;
            // SALIDA
            for (K = POS; K >= 1; K += -1)
            {
                Console.Write(VEC[K] + " ");
            }
            Console.WriteLine();
            Console.Write("Pulse una Tecla:");
            Console.ReadLine();
        
        }
    }
}
