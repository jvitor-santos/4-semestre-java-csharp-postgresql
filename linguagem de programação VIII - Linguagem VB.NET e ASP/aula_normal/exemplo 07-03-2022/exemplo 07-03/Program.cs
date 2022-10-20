using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemplo_07_03
{
    class Program
    {
        static void Main(string[] args)
        {
            int idade1, idade2;
            string nome1, nome2;
            Console.Write("Digite nome da 1ª pessoa: ");      nome1 = Console.ReadLine();
            Console.Write("Digite a idade da 1ª pessoa: ");  idade1 = int.Parse(Console.ReadLine());

            Console.Write("Digite nome da 2ª pessoa: ");      nome2 = Console.ReadLine();
            Console.Write("Digite a idade da 2ª pessoa: ");   idade2 = int.Parse(Console.ReadLine());

            if (idade1 > idade2)
            {
                Console.Write("\n{0} é mais velho(a) ", nome1);
                Console.WriteLine("com {0} anos de idade", idade1);
            }else
            {
                if (idade2 > idade1)
                {
                    Console.Write("\n{0} é mais velho(a) ", nome2);
                    Console.WriteLine("com {0} anos de idade", idade2);
                }
                else{
                    Console.WriteLine("\n{0} e {1} têm {2} anos de idade.", nome1, nome2, idade1);
                }
            }
            Console.ReadKey();
        }
    }
}
