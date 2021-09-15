using System;

namespace Exemplos_URI
{
    class Program
    {
        public static void p1001() {
            int a, b, x;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            x = a + b;
            Console.Write("X = {0}\n", x);
        }

        public static void p1002()
        {
            double area, raio;
            raio = Convert.ToDouble(Console.ReadLine());
            area = 3.14159 * Math.Pow(raio, 2);

            Console.Write("A={0}", area.ToString("0.0000") );
        }
        public static void p1003()
        {
            Console.Write("1003");
        }
        public static void p1004()
        {
            Console.Write("1003");
        }
        public static void p1005()
        {
            Console.Write("1003");
        }
        public static void p1006()
        {
            Console.Write("1003");
        }
        public static void p1007()
        {
            Console.Write("1003");
        }
        public static void p1008()
        {
            Console.Write("1003");
        }
        public static void p1009()
        {
            Console.Write("1003");
        }
        public static void p1010()
        {
            string linha1, linha2;
            int n1, quant1, n2, quant2;
            double preco1, preco2, valor_total;

            linha1 = Console.ReadLine();
            //  VALORES DA PRIMEIRA LINHA
            string[] matriz = linha1.Split(' ');
            n1 = Convert.ToInt32( matriz[0] );
            quant1 = Convert.ToInt32( matriz[1] );
            preco1 = Convert.ToDouble( matriz[2] );



            linha2 = Console.ReadLine();
            //  VALORES DA PRIMEIRA LINHA
            matriz = linha2.Split(' ');
            n2 = Convert.ToInt32(matriz[0]);
            quant2 = Convert.ToInt32(matriz[1]);
            preco2 = Convert.ToDouble(matriz[2]);

            //  CALCULO
            valor_total = (quant1 * preco1) + (quant2 * preco2);

            Console.Write("VALOR A PAGAR: R$ {0}", valor_total.ToString("0.00"));

        }

        static void Main(string[] args)
        {
            int prog;

            do
            {
                Console.Write("\n\n\t| 0 para sair |\nDigite o programa desejado: ");
                prog = Convert.ToInt32(Console.ReadLine());
                Console.Write("-----------------\n");

                if( prog == 0 )
                {
                    Console.Write("\nObrigado por utilizar nossos programas.\n");
                    break;
                }

                switch (prog)
                {
                    case 1001:  Program.p1001();    break;
                    case 1002:  Program.p1002();    break;
                    case 1003:  Program.p1003();    break;
                    case 1004:  Program.p1004();    break;
                    case 1005:  Program.p1005();    break;
                    case 1006:  Program.p1006();    break;
                    case 1007:  Program.p1007();    break;
                    case 1008:  Program.p1008();    break;
                    case 1009:  Program.p1009();    break;
                    case 1010:  Program.p1010();    break;

                    default:
                        Console.Write("Opção inválida");
                        break;
                }
            } while ( prog != 0 );
        }
    }
}
