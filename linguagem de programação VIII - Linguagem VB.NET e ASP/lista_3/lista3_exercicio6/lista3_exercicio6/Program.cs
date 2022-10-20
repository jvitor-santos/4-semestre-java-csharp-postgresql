using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista3_exercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            string sexo;
            double altura;

            Console.Write("F- Feminino \nM- Masculino \nSexo:");        sexo = Console.ReadLine().ToUpper();
            Console.Write("Altura: ");                                  altura = double.Parse(Console.ReadLine());

            Console.WriteLine(peso_ideal(sexo, altura));
            Console.ReadKey();
        }

        static double peso_ideal(string s, double h)
        {
            double resultado=0;
            if (s =="F")
            {
                resultado=(62.1 *h)-44.7;
            }
            if (s=="M")
            {
                resultado = (72.7 * h) - 58;
            }
            return resultado;
        }
    }
}
