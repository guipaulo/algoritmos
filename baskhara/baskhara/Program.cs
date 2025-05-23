using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace baskhara
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double A = 0;
            double B = 0;
            double C = 0;

            A = Convert.ToDouble(Console.ReadLine());
            B = Convert.ToDouble(Console.ReadLine());
            C = Convert.ToDouble(Console.ReadLine());

            double delta = (Math.Pow(B, 2) - (4*A*C));

            double x1 = (-B + (Math.Sqrt(delta))/(2 * A));
            double x2 = (-B - (Math.Sqrt(delta)) /( 2 * A));

            Console.WriteLine("A primeira raíz é "+ x1);
            Console.WriteLine("A segunda raíz é " + x2);
        }
    }
}
