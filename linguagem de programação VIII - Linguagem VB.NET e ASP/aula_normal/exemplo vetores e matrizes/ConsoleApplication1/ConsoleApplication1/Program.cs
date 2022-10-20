using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string palavra;
            int i;

            Console.Write("Digite uma palavra: ");
            palavra = Console.ReadLine().ToLower();

            Console.WriteLine("\nVogais da palavra: {0} \n", palavra);

            char[] vetor = palavra.ToCharArray();

            int tamanho = vetor.Length;

            for (i=0; i<tamanho; i++)
            {
                if (vetor[i] == 'a' || vetor[i] == 'e' || vetor[i] == 'i' || vetor[i] == 'o' || vetor[i] == 'u')
                    Console.Write(" {0}", vetor[i]);
            }

            Console.ReadKey();
        }
    }
}
