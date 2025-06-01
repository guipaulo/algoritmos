using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace maior_numero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int maior = 0;
            int menor = 0;

            Console.WriteLine("Digite os numeros: ");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                num1 = maior;
                num2 = menor;
            }
            else
            {
                if (num1 < num2) 
                {
                    num1 = menor;
                    num2 = maior;
                }
            Console.WriteLine(maior + " " + menor);
            }
        }
    }
}
