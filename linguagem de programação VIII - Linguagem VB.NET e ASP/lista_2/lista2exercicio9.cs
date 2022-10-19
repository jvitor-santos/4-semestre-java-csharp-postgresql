using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2exercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, cont_impar = 0, cont_par = 0, cont_posi = 0, cont_nega = 0;
            string resp = "";

            while (resp != "S" && resp != "SIM")
                {
                Console.Write("Digite um numero: ");        i = int.Parse(Console.ReadLine());

                if (i%2==0)
                {
                    cont_par+= 1;
                }else
                {
                    cont_impar += 1;
                }if(i>=0)
                {
                    cont_posi += 1;
                }else
                {
                    cont_nega += 1;
                }
                Console.WriteLine("Deseja encerrar? ");
                resp = Console.ReadLine().ToUpper();
            }
            Console.WriteLine("A quantidade de numeros pares foi de: {0}, a de numeros impares: {1}, a de numeros positivos: {2}, e a de numeros negativos: {3}", cont_par, cont_impar, cont_posi, cont_nega);
            Console.ReadKey();
        }
    }
}
