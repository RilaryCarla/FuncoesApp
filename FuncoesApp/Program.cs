using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FuncoesApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a forma geométrica que você deseja calcular q,t,r,l: ");
            string fg = Console.ReadLine();

            switch (fg)
            {
                case "q":
                quadrado();
                break;

                case "t":
                trapezio();
                break;

                case "r":
                retangulo();
                break;

                case "l":
                losango();
                break;

                default:
                Console.WriteLine("Opção Invalida");
                break;
            }
            Console.ReadKey();
        }
        static void quadrado()
        {
            Console.WriteLine("Digite o valor da base do seu quadrado: ");
            double bq = double.Parse(Console.ReadLine());

            double valor = bq * bq;
            Console.WriteLine("O resultado da área do seu quadrado é " + valor);
        }
        static void trapezio()
        {
            Console.WriteLine("Digite o valor da base maior: ");
            double bM = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da base menor: ");
            double bm = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da altura: ");
            double A = double.Parse(Console.ReadLine());

            double valor = (bM + bm) * A / 2;
            Console.WriteLine("O resultado da área do seu trapézio é " + valor);
        }
        static void retangulo()
        {
            Console.WriteLine("Digite o valor da base do seu retângulo: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da altura do seu retângulo: ");
            double a = double.Parse(Console.ReadLine());

            double valor = b * a;
            Console.WriteLine("O valor da área do seu retângulo é " + valor);
        }
        static void losango()
        {
            Console.WriteLine("Digite o valor da diagonal menor do lonsango: ");
            double dm = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor da diagonal maior do losango: ");
            double dM = double.Parse(Console.ReadLine());

            double valor = dM * dm / 2;
            Console.WriteLine("O valor da área do seu losango é " + valor);
        }
    }
}
