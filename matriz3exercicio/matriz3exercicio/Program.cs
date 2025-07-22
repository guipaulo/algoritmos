using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matriz3exercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matriz = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Digite um número para incluir na matriz: ");
                    matriz[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0;i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine("Matriz " + "[" + i + "," + j + "] = " + matriz[i, j]);
                }
            }
        }
    }
}
