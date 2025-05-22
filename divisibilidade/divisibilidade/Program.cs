using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace divisibilidade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Faça um programa que indique se um número que o usuário digitou é divisível por 4 e por 7 ao mesmo tempo
             * mas não divisível por 5.
             * A saída deve ser um mensagem 'sim' ou 'nao' (minúsculos e sem o til).
            */

            int numero = 0;
            Console.WriteLine("Digite um número: ");
            numero = Convert.ToInt32(Console.ReadLine());
            
            if (numero % 7 == 0 && numero % 4 == 0 && numero % 5  != 0)
            {
                Console.WriteLine("SIM");
            }
            else 
            {
                Console.WriteLine("NÃO");
            }

        }
    }
}
