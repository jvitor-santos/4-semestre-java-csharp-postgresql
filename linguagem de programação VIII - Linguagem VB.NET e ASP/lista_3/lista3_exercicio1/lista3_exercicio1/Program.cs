using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista3_exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            String nome;
            int nota1, nota2,media;

            Console.Write("Digite o nome do aluno: ");          nome = Console.ReadLine();

            Console.Write("Digite a primeira nota: ");          nota1 = int.Parse(Console.ReadLine());
            Console.Write("Digite a segunda nota: ");           nota2 = int.Parse(Console.ReadLine());

            media = calcularMedia(nota1, nota2);
            lerNota(media,nome);

            Console.ReadKey();


        }

        static int calcularMedia(int x, int z)
        {
            int med;
            med = (x + z) / 2;
            return med;
        }

        static void lerNota(double x, String no)
        {
            if (x >= 7)
            {
                Console.Write("Aluno {0} aprovado!", no);
            }
            else
            {
                Console.Write("Aluno {0} reprovado!", no);
            }

        }
    }
}
