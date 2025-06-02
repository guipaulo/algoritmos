using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anos_bisextos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite dois anos bisextos: ");
            int ano1 = Convert.ToInt32(Console.ReadLine());
            int ano2 = Convert.ToInt32(Console.ReadLine());

            for (int i = ano1; i < ano2; i=i+4)
            {
                Console.WriteLine(i);
            }

        }   
    }
}
