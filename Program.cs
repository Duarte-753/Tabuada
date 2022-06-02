using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tabuada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // ADS Nome: Julio Duarte Batista RA:6322046

            int i, total,numero;

            Console.Write("\nTabuada Simples.");
            Console.WriteLine("\nDigite um número: ");
            numero=Convert.ToInt32(Console.ReadLine());
            for ( i = 1; i <=10 ; i++)
            {
                total = numero*i;
                Console.WriteLine(numero +" X "+i+" = "+total);
            }

            Console.ReadLine(); 
        }
    }
}
