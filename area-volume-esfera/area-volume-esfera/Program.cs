using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace area_volume_esfera
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double raio;
            double pi = 3.1416;
            double area;
            double volume;

            Console.WriteLine("Digite o valor do raio: ");
            raio = Convert.ToDouble(Console.ReadLine());

            area = 4 * pi * raio*raio;
            volume = (4 * pi * raio * raio * raio)/3;

            Console.WriteLine("A área da esfera é " + area);
            Console.WriteLine("O volume da esfera é: " + volume);

        }
    }
}
