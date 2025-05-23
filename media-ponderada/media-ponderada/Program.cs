using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace media_ponderada
{
    internal class Program
    {
        static void Main(string[] args)
        { /*
           * Escreva um programa que recebe 3 notas de prova e calcula
           * A média delas
           * A média ponderada delas, considerando pesos 2, 2 e 3
           * A média ponderada delas, considerando pesos 1, 2 e 2
           */

            double num1 = 0, num2 = 0, num3 = 0;
            double media, pond1, pond2;

            Console.WriteLine("Digite a primeira nota ");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a segunda nota ");
            num2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a terceira nota ");
            num2 = Convert.ToDouble(Console.ReadLine());

            media = (num1 + num2 + num3) / 3;
            pond1 = ((num1 * 2) + (num2 * 2) * (num3 * 3)) / 7;
            pond2 = (num1 * 2) + (num2 * 2) * (num3 * 2) / 5;

            Console.WriteLine("Suas notas são: \n" + pond1);

        }
    }
}
