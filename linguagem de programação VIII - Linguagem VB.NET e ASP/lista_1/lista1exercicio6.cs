using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            double real, dolar,calculo;
            Console.Write("Digite o valor em real: ");
            real = double.Parse(Console.ReadLine());

            Console.Write("Digite a cotação do dolar: ");
            dolar = double.Parse(Console.ReadLine());

            calculo = real / dolar;

            Console.Write("A conversão de {0} real para {1} dolar é de: {2:N2} dolar", real, dolar, calculo);

            Console.ReadKey();
        }
    }
}
