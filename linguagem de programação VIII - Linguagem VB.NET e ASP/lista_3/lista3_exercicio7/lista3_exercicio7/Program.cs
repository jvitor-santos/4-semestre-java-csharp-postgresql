using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista3_exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            int quadrante, x, y;

            Console.Write("Digite o valor de X: ");             x = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor de Y: ");             y = int.Parse(Console.ReadLine());

            quadrante = verificar(x, y);
            Console.WriteLine("{0},{1} = Quadrante {2}", x, y, quadrante);
            Console.ReadKey();
        }
        static int verificar(int a, int b)
        {
            int resultado = 0;
            if (a>0 && b>0)
            {
                resultado = 1;
            }

            if (a<0 && b>0)
            {
                resultado = 2;
            }

            if (a<0 && b<0)
            {
                resultado = 3;
            }

            if (a>0 && b<0)
            {
                resultado = 4;
            }
            return resultado;
        }
    }
}
