using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            string a, b;
            Console.Write("Digite o nome da primeira pessoa: ");
            a = Console.ReadLine();

            Console.Write("Digite o nome da segunda pessoa: ");
            b = Console.ReadLine();

            Console.WriteLine("O nome das duas pessoas com caracteres maiusculos: {0} e {1} ", a.ToUpper(), b.ToUpper());
            Console.WriteLine("A quantidade de caracteres no primeiro nome é de: {0}, e do segundo nome é: {1} ", a.Length, b.Length);
            Console.WriteLine("Apenas os três primeiros caracteres do primeiro nome: {0}, e do segundo nome: {1}", a.Substring(0, 3), b.Substring(0, 3));

            Console.ReadKey();
        }
    }
}
