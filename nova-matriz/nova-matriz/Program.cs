using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nova_matriz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[3, 3];

            for (int m = 0; m < matriz.GetLength(0); m++)
            {
                for (int n = 0; n < matriz.GetLength(1); n++)
                {
                    matriz[m, n] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int m = 0; m <= matriz.Length; m++)
            {
                for (int n = 0; n <= matriz.Length; n++)
                {
                    Console.Write(matriz[m, n]);
                }
            }
            Console.WriteLine();
        }   
    }
}
