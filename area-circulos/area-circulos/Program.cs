using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace area_circulos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double raio1;
            double area1;

            double raio2;
            double area2;

            double pi = 3.14;

            Console.WriteLine("Digite o raio do primeiro circulo: ");
            raio1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o raio do segundo circulo: ");
            raio2 = Convert.ToDouble(Console.ReadLine());

            area1 = pi * (raio1 * raio1);
            area2 = pi * (raio2 * raio2);

            if (area1 > area2)
            {
                Console.WriteLine("PRIMEIRO");
            }
            if (area1 == area2)
            {
                Console.WriteLine("IGUAIS");
            }
            if (area1 < area2)
            {
                Console.WriteLine("SEGUNDO");
            }
        }
    }
}
