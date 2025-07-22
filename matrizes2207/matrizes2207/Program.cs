using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrizes2207
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[5,5];

            for(int i = 0; i <=4; i++)
            {
                for (int j = 0; j <=4; j++)
                {
                    Console.Write("Digite um número na posição " + i + "," + j + ": ");
                    matriz[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i <=4;i++)
            {
                for (int j = 0;j <=4;j++)
                {
                    Console.WriteLine("Elemento da posição " + i + j +" é " + matriz[i, j]);
                }
            }
        }
    }
}
