using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace impressão_triangulo_matriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] x =  new int[3, 3];

            // Implementando a raiz:
            for (int i = 0;  i < x.GetLength(0); i++)
            {
                for(int j=0; j < x.GetLength(1); j++)
                {
                    Console.WriteLine("Digite um número para a posição " + i + ", " + j + ": ");
                    x[i,j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            //Imprimindo o trianculo superior:
            Console.WriteLine("Imprimindo o triângulo superior da matriz: ");
            for (int i = 0; i < x.GetLength(0); i++)
            {
                for (int j = 0; j < x.GetLength(1); j++)
                {
                    Console.WriteLine(x[i, j]);
                }
            }

            //Imprimindo o triangulo inferior
            Console.WriteLine("Imprimindo o triângulo inferior da matriz: ");
            for(int i = 0;i < x.GetLength(0); i++) 
            {
                for (int j = 0 ; j<= 1; j++)
                {
                    Console.WriteLine(x[i, j]);
                }
            }

            Console.WriteLine("Imprimindo a diagonal principal da matriz:" );
            for(int i = 0; i < x.GetLength(0); i++)
            {
                Console.WriteLine(x[i, i]);
            }
        }
    }
}
