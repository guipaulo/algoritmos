using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_multiplos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            for (int i = 1; i <= 10; i++) 
            {
                Console.WriteLine(numero * i);
            }
        }
    }
}
