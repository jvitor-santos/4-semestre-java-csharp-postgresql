using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, calculo,quadrado;

            Console.Write("Digite um valor para A: ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Digite um valor para B: ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Digite um valor para C: ");
            c = double.Parse(Console.ReadLine());

            calculo = ((quadrado=Math.Pow(a, 2)) * (5 - c)) / (b - (a % 4));

            Console.Write("O resultado do calculo A²*5-C/(B-A%4) é: " + calculo);
            Console.ReadKey();
        }
    }
}
