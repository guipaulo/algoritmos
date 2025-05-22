using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace angulo_triangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {/*
          Escreva um programa em Python que peça para o usuário digitar o primeiro e o segundo ângulo de um triângulo 
          e em seguida o seu programa deverá informar qual o terceiro ângulo do triângulo.
         */

            double ang1;
            double ang2;
            double ang3;

            Console.WriteLine("Digite o primeiro angulo: ");
            ang1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite o segundo angulo: ");
            ang2 = Convert.ToDouble(Console.ReadLine());

            ang3 = 180 - (ang1 + ang2);

            if (ang1+ang2+ang3 > 180)
            {
                Console.WriteLine("Essa figura não é um triângulo");
            }

            Console.WriteLine("O angulo 3 é: " + ang3);
        }
    }
}
