using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int x=0,i,maior=x;

            for (i = 1; i <= 15; i++)
            {
                Console.Write("Digite o {0}º: ", i);
                x = int.Parse(Console.ReadLine());

                if (x>maior)
                {
                    maior = x;
                }
            }
            Console.Write("O maior numero digitado foi: " + maior);
            Console.ReadKey();
        }
    }
}
