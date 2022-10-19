using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2exercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            string resp = "";

            while(resp!="S" && resp!="SIM")
            {
                int c, n, e=0,extra,calculo;

                Console.Write("Informe o codigo do operário: ");
                c = int.Parse(Console.ReadLine());

                Console.Write("Informe o numero de horas trabalhada: ");
                n = int.Parse(Console.ReadLine());

                if(n>50)
                {
                    extra = n - 50;
                    e = extra * 20;
                    calculo = (50 * 10)+e;
                }else
                {
                    calculo = n * 10;
                }
                Console.WriteLine("O salário do funcionario {0} é: {1}, e o excedente é: {2}", c, calculo, e);
                Console.WriteLine("Deseja encerrar o programa? ");
                resp = Console.ReadLine().ToUpper();
            }
            Console.ReadKey();
        }
    }
}
