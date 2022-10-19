using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            double x,calculo=0,media=0;

            for (i=1;i<=10;i++)
            {
                Console.Write("Digite a {0}ª nota: ", i);
                x = double.Parse(Console.ReadLine());

                if (x<=10)
                {
                    calculo += x;
                }else
                {
                    Console.WriteLine("Numero informado está incorreto, reinicie o programa!");
                    break;
                }
            }
            media = calculo / 10;
            Console.WriteLine("A média do aluno foi de: " + media);
            Console.ReadKey();
        }
    }
}
