using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace multiplicacao_matrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[,] matriz = new double[2, 2];
            double[,] resultante = new double [2, 2];
            double maior = -1328137123;

            for(int i = 0; i <= 1; i++)
            {
                for (int j = 0; j <= 1; j++)
                {
                    matriz[i, j] = Convert.ToDouble(Console.ReadLine());

                    if (matriz[i, j] > maior)
                    {
                        maior = matriz[i, j];
                    }
                }
            }

            for(int i = 0;i <= 1; i++)
            {
                for(int j = 0;j <= 1; j++)
                {
                    resultante[i, j] = matriz[i, j] * 5;
                }
            }

            for (int i = 0; i <= 1; i++)
            {
                for (int j = 0; j <= 1; j++)
                {
                    Console.Write(resultante[i, j] + "\t");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
