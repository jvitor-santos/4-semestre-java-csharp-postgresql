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
            int numero;
            double quadrado;
            Console.Write("Digite um numero para calcular seu quadrado: ");
            numero = int.Parse(Console.ReadLine());

            quadrado = Math.Pow(numero,2);

            Console.WriteLine("O resultado de {0} ao ² é: " + quadrado,numero);
            Console.ReadKey();

        }
    }
}
