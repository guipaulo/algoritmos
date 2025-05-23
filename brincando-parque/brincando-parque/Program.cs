using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace brincando_parque
{
    internal class Program
    {
        static void Main(string[] args)
        { /*
           * Nos parques de diversão, alguns brinquedos tem idade e altura mínimas para poder andar neles.
           * O parque Ambrolândia possui 3 brinquedos que possuem essa limitação:
           * Barca Viking: 1,5m de altura e 12 anos.
           * Elevator of Death: 1,4m de altura e 14 anos.
           * Final Killer: 1,7m de altura ou 16 anos.
           * Dada a altura e a idade de uma pessoa,
             faça um programa que identifique quantos brinquedos ele pode andar.
           */

            int idade = 0;
            int altura = 0;
            int brinquedos = 0;

            Console.WriteLine("Digite sua altura: ");
            altura = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite sua idade: ");
            idade = Convert.ToInt32(Console.ReadLine());

            if (altura >= 84 && idade >= 14)
            {
                brinquedos = brinquedos + 1;
            }
            if (altura >= 90 &&  idade >= 12)
            {
                brinquedos = brinquedos + 1;
            }
            if (altura >= 102 && idade >= 16)
            {
                brinquedos = brinquedos + 1;
            }

            Console.WriteLine(brinquedos);
        }
    }
}
