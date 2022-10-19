using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista3_exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, fatorial;
            Console.Write("Digite um numero para fazer o fatorial dele: ");
            numero = int.Parse(Console.ReadLine());

            fatorial= calcularFatorial(numero);
            Console.Write(fatorial);
            Console.ReadKey();
        }
        static int calcularFatorial(int x)
        {
            int i,fat=1;
            for (i=1;i<=x;i++)
            {
                fat = fat * i;
            }
            return fat;
        }
    }
}
