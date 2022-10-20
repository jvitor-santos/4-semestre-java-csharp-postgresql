using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista3_exercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            double base_1, altura, hipo;

            Console.Write("Digite o tamanho da base: ");            base_1 = double.Parse(Console.ReadLine());
            Console.Write("Digite o tamanho da altura: ");          altura = double.Parse(Console.ReadLine());
            hipo = hipotenusa(base_1, altura);
            Console.WriteLine("Altura: {0} e Base: {1} \nHipotenusa: {2}", altura, base_1, hipo);
            Console.ReadKey();
        }

        static double hipotenusa(double b, double h)
        {
            double calculo;
            calculo = Math.Sqrt((b * b) + (h * h));
            return calculo;
        }
    }
}
