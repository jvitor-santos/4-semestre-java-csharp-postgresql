using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x=0, z=0;

            Console.Write("Digite o primeiro numero: ");
            x = int.Parse(Console.ReadLine());

            Console.Write("Digite o segundo numero: ");
            z = int.Parse(Console.ReadLine());

            if (x > z)

            {

                for (x=x; x>=z;x--)
                {
                    if (x % 2 != 0)
                    {
                        Console.WriteLine(x);
                    }
                }

            } else
            {

                for (z=z; z >= x; z--)
                {
                    if (z % 2 != 0)
                    {
                        Console.WriteLine(z);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
