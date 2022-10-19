using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista3_exercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Boolean triangulo_1 = false, triangulo_2 = false, triangulo_3 = false;

            Console.Write("Digite o valor de A: ");         a = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor de C: ");         b = double.Parse(Console.ReadLine());
            Console.Write("Digite o valor de C: ");         c = double.Parse(Console.ReadLine());

            if ((a<(b+c)) && (b<(a+c)) && (c<(a+b)))
            {
                triangulo_1 = equilatero(a, b, c);
                if (triangulo_1==false)
                {
                    triangulo_2 = isosceles(a, b, c);
                }if (triangulo_1 ==false && triangulo_2==false)
                {
                    triangulo_3 = true;
                }

            } else
            {
                triangulo_1 = false;
                triangulo_2 = false;
                triangulo_3 = false;
            }

            Console.Write("Equilatero: {0} \nIsosceles: {1} \nEscaleno: {2}", triangulo_1, triangulo_2, triangulo_3);
            Console.ReadKey();
        }

        static Boolean equilatero(double x, double y, double z)
        {
            Boolean triangulo = false;
            if (x==y && y==z)
            {
                triangulo = true;
            }
            return triangulo;
        }

        static Boolean isosceles(double x, double y, double z)
        {
            Boolean triangulo = false;
            if (x==y || x==z || y==z)
            {
                triangulo = true;
            }
            return triangulo;
        }
    }
}
