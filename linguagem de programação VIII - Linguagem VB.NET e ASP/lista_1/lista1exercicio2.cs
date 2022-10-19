using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero,calculo;

            Console.Write("Digite um numero para calcular o seu dobro: ");
            numero = int.Parse(Console.ReadLine());

            calculo = numero * 2;

            Console.Write("O resultado do calculo do dobro do numero {0} é: " + calculo, numero);
            Console.ReadKey();
        }
    }
}
