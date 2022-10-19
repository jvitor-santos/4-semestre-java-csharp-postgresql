using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            int x, z, a, b,quant = 0;

            Console.Write("Digite o primeiro numero: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo numero: ");
            z = int.Parse(Console.ReadLine());

            if (x<z)
            {
                a = x;
                b = z;
            }else
            {
                a = z;
                b = x;
            }
            for (a = a;a <= b; a++)
            {
                if (a%2 != 0)
                {
                    quant += 1;
                }
            }
            Console.Write("A quantidade de numeros impares entre {0} e {1} incluindo eles é de: {2}", x, z, quant);
            Console.ReadKey();
        }
    }
}
