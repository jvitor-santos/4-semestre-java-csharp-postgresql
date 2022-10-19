using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1exercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("Digite o valor de A: ");
            a = int.Parse(Console.ReadLine());

            Console.Write("Digite o valor de B: ");
            b = int.Parse(Console.ReadLine());

            a += b;
            b = a - b;
            a -= b;

            Console.Write("O valor de A é de: {0}, e de B é: {1} ", a, b);

            Console.ReadKey();
        }
    }
}
