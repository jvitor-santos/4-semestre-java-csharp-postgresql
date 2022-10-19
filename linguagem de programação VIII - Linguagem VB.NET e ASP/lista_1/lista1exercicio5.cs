using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1exercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b = 18;
            string verdade = "sim", falso = "não";

            Console.Write("Digite sua idade: ");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("{0} é maior de idade ? resposta: ", a);
            Console.WriteLine(a > b ? verdade : falso);

            Console.ReadKey();
        }
    }
}
