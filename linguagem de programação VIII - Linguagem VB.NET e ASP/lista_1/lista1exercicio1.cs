using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista1exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome, cidade;
            int idade;

            Console.Write("Qual seu nome: ");
            nome = Console.ReadLine();

            Console.Write("Qual sua idade: ");
            idade = int.Parse(Console.ReadLine());

            Console.Write("Qual a cidade onde você reside: ");
            cidade = Console.ReadLine();

            Console.WriteLine("Seu nome é: " + char.ToUpper(nome[0]) + nome.Substring(1));
            Console.WriteLine("Sua idade é: " + idade);
            Console.WriteLine("A cidade onde você reside é: " + char.ToUpper(cidade[0]) + cidade.Substring(1));
            Console.ReadKey();
        }
    }
}
