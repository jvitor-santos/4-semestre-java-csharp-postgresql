using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista3_exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int opc;
            Console.Write("1- Soma \n2- Subtração \n3- Divisão \n4- Multiplicação \n5- Resto da Divisão \n6- Dobro \n7- Quadrado \n8- Cubo \n9- Raiz Quadrada \n0- Sair \nEscolha uma das opções seguintes: ");
            opc = int.Parse(Console.ReadLine());

            while (opc != 0)
            {
                switch (opc)
                {
                    case 1:
                        soma();
                        break;

                    case 2:
                        sub();
                        break;

                    case 3:
                        divi();
                        break;

                    case 4:
                        mult();
                        break;

                    case 5:
                        resto();
                        break;

                    case 6:
                        dobro();
                        break;

                    case 7:
                        quad();
                        break;

                    case 8:
                        cubo();
                        break;

                    case 9:
                        raiz();
                        break;

                    default:
                        Console.WriteLine("Opção digitada invalida!");
                        break;
                }

                Console.Write("Informe a opção: ");
                opc = int.Parse(Console.ReadLine());
            }

            Console.ReadKey();
        }

        static void soma()
        {
            double x, y, resultado;
            Console.Write("Digite o primeiro numero: ");            x = double.Parse(Console.ReadLine());
            Console.Write("Digite o segundo numero: ");             y = double.Parse(Console.ReadLine());

            resultado = x + y;
            Console.WriteLine("A soma de {0} + {1} é igual a: {2}", x, y, resultado);
        }

        static void sub()
        {
            double x, y, resultado;
            Console.Write("Digite o primeiro numero: "); x = double.Parse(Console.ReadLine());
            Console.Write("Digite o segundo numero: "); y = double.Parse(Console.ReadLine());

            resultado = x - y;
            Console.WriteLine("A subtração de {0} - {1} é igual a: {2}", x, y, resultado);
        }

        static void divi()
        {
            double x, y, resultado;
            Console.Write("Digite o primeiro numero: "); x = double.Parse(Console.ReadLine());
            Console.Write("Digite o segundo numero: "); y = double.Parse(Console.ReadLine());

            resultado = x / y;
            Console.WriteLine("A divisão de {0} / {1} é igual a: {2}", x, y, resultado);
        }

        static void mult()
        {
            double x, y, resultado;
            Console.Write("Digite o primeiro numero: "); x = double.Parse(Console.ReadLine());
            Console.Write("Digite o segundo numero: "); y = double.Parse(Console.ReadLine());

            resultado = x * y;
            Console.WriteLine("A multiplicação de {0} X {1} é igual a: {2}", x, y, resultado);
        }

        static void resto()
        {
            double x, y, resultado;
            Console.Write("Digite o primeiro numero: "); x = double.Parse(Console.ReadLine());
            Console.Write("Digite o segundo numero: "); y = double.Parse(Console.ReadLine());

            resultado = x % y;
            Console.WriteLine("O resto da divisão de {0} / {1} é igual a: {2}", x, y, resultado);
        }

        static void dobro()
        {
            double x, resultado;
            Console.Write("Digite um numero para ver o seu dobro: ");           x = double.Parse(Console.ReadLine());
            resultado = x * 2;
            Console.WriteLine("O dobro de {0} é igual a: {1}", x, resultado);
        }

        static void quad()
        {
            double x, resultado;
            Console.Write("Digite um numero para ver o seu quadrado: "); x = double.Parse(Console.ReadLine());
            resultado = x * x;
            Console.WriteLine("{0} ao quadrado é igual a: {1}", x, resultado);
        }

        static void cubo()
        {
            double x, resultado;
            Console.Write("Digite um numero para ver o seu cubo: "); x = double.Parse(Console.ReadLine());
            resultado = x * x * x;
            Console.WriteLine("O cubo de {0} é igual a: {1}", x, resultado);
        }

        static void raiz()
        {
            double x, resultado;
            Console.Write("Digite um numero para ver o sua Raiz Quadrada: "); x = double.Parse(Console.ReadLine());
            resultado = Math.Sqrt(x);
            Console.WriteLine("A Raiz Quadrada de {0} é igual a: {1}", x, resultado);
        }
    }
}
