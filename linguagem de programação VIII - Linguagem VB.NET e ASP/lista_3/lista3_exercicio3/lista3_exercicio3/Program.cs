using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista3_exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int v1, v2;

            Console.Write("Digite o primeiro valor: ");             v1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo valor: ");              v2 = int.Parse(Console.ReadLine());

            diferenca(v1, v2);
            Console.ReadKey();
        }
        static void diferenca(int x, int z)
        {
            int calculo;
            if (x > z)
            {
                calculo = x - z;
                Console.Write("A diferença entre {0} e {1} é: {2}", x, z, calculo);
            }
            else
            {
                calculo = z - x;
                Console.Write("A diferença entre {0} e {1} é: {2}", z, x, calculo);
            }
        }
    }
}
