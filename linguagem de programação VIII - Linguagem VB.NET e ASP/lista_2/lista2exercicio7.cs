using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lista2exercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            for(i=0; i<=100; i++)
            {
                if(i%10==0)
                {
                    Console.WriteLine("{0} é Multiplo de 10!",i);
                }else
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
    }
}
