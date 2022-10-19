using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1exercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x,z,calcula;

            Console.Write("Digite um numero para exibir a tabuada: ");
            x = int.Parse(Console.ReadLine());

            for (z = 0; z <= 10; z++)
            {
                calcula = x * z;
                Console.WriteLine("{0} X {1} = {2}", x, z, calcula);
            }
           Console.ReadKey();
        }
    }
}
