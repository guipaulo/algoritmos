using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace matrizes
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            //Declarando um Array
            string[] semana = new string[7];
            string[,] nome = new string[2,2];

            semana[0] = "Segunda-feira";
            semana[1] = "Terça-feira";
            semana[2] = "Quarta-feira";
            semana[3] = "Quinta=feira";
            semana[4] = "Sexta-feira";
            semana[5] = "Sabado";
            semana[6] = "Domingo";

            Console.WriteLine(semana[6] + "\n");

            for (int i = 0; i < semana.Length; i++)
            {
                Console.WriteLine(semana[i] + "\n");
            }

            Console.WriteLine("Digite um nome: ");

            for (int linha = 0; linha < 2; linha++)
            {
                for (int coluna = 0; coluna < 2; coluna++)
                {
                    nome[linha, coluna] = Console.ReadLine();
                }
                Console.WriteLine();
            }

            for (int linha = 0; linha < 2; linha ++)
            {
                for(int coluna = 0; coluna <2; coluna++)
                {
                    Console.Write(nome[linha, coluna] + " ");
                }
            }   Console.WriteLine();
        }
    }
}
