using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace acidez_solucao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Escreva um programa que leia o valor do índice de acidez (pH) de uma solução e informe se ela é ácida, 
                básica ou neutra, sendo que o pH deve estar entre 0 e 14.
                A solução é ácida quando o pH é menor que 7
                A solução é básica quando o pH é maior que 7
                Caso contrário a solução é neutra
             */

            double ph;

            Console.WriteLine("Digite o valor do pH da solução: ");
            ph = Convert.ToDouble(Console.ReadLine());

            if (ph > 7) 
            {
                Console.WriteLine("Solução básica");
            }
            if (ph == 7)
            {
                Console.WriteLine("Solução neutra");
            }
            if (ph < 7)
            {
                Console.WriteLine("Solução ácida");
            }

        }
    }
}
