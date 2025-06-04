using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;
            Console.WriteLine(" \nBem - vindo ao mundo do RPG! ");
            Console.WriteLine("\nConheça os personagens disponíveis, 1- Guerreiro, 2- Arqueiro, 3- Mago, 4- Curandeiro e 5- Ladino. ");
            Console.WriteLine("\nPara iniciar a partida, digite um numero referente ao seu personagem escolhido: ");
            opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)

    {
                case 1:
                    Console.WriteLine("Seu personagem é o Guerreiro! ");
                    break;
                case 2:
                    Console.WriteLine("Seu personagem é o Arqueiro! ");
                    break;
                case 3:
                    Console.WriteLine("Seu personagem é o Mago! ");
                    break;
                case 4:
                    Console.WriteLine("Seu personagem é o Curandeiro!" );

                break;

                case 5:
                    Console.WriteLine("Seu personagem é o Ladino! ");

                break;
                default:
                    Console.WriteLine("O número informado não é compatível com as opções");
                    break;

            }


        }
    }
}
