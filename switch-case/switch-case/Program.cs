using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_case
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escolha uma Opção de 1 a 5");
            int opcao = Convert.ToInt32(Console.ReadLine());
            switch (opcao)
            {
                case 1:
                    Console.WriteLine("Guerreiro");
                    Console.WriteLine("Forte em combate corpo a corpo");
                    break;
                case 2:
                    Console.WriteLine("Arqueiro");
                    Console.WriteLine("Excelente em ataques à distância");
                    break;
                case 3:
                    Console.WriteLine("Mago");
                    Console.WriteLine("Usa magias poderosas");
                    break;
                case 4:
                    Console.WriteLine("Curandeiro");
                    Console.WriteLine("Pode curar aliados");
                    break;
                case 5:
                    Console.WriteLine("Ladino");
                    Console.WriteLine("Ágil e mestre em furtividade");
                    break;
                default:
                    Console.WriteLine("Opção inválida. Escolha um número de 1 a 5");
                    break;


            }
        }
    }
}
