using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2exercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            int x,i,fat=1;
            Console.Write("Digite um numero para fatorar: ");
            x = int.Parse(Console.ReadLine());

            for(i=1;i<=x; i++)
            {
                fat = fat * i;
            }
            Console.WriteLine("O fatorial de {0} é = {1}", x, fat);
            Console.ReadKey();
        }
    }
}
