using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1exercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            int w, x, y, z;
            bool calculo;
            Console.Write("Digite o valor da variavel w : ");
            w = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor da variavel x : ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor da variavel y : ");
            y = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor da variavel z : ");
            z = int.Parse(Console.ReadLine());

            calculo = ((x >= y) && (z <= x)) || ((x == w) && (y == z)) || (!(x != w));
            Console.WriteLine("A tabela verdade para o calculo, ((X >= Y) AND (Z <=X)) OR ((X == W) AND (Y == Z)) OR (NOT(X != W)) é: " + calculo);

            Console.ReadKey();
        }
    }
}
