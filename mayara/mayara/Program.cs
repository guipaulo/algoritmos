using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mayara
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {//inicio 
                double nota1, nota2, nota3, media;

                Console.WriteLine("Digite o valor da sua nota referente à primeira unidade: ");
                nota1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite o valor da sua nota referente à segunda unidade: ");
                nota2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Digite o valor da sua nota referente à terceira unidade: ");
                nota3 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("SUA MÉDIA FINAL É: " + ((nota1 + nota2 + nota3) / 3));
            
                media = (nota1 + nota2 + nota3) / 3;

                if (media >= 7.0)
	            {
                    Console.WriteLine("Você está APROVADO! ");
                }

                if (media >= 5.0)
	            {
                    Console.WriteLine("Você está na RECUPERAÇÃO! ");
                }


                else
                {
                    Console.WriteLine("Você está REPROVADO! ");
                }

            }// fim
        }
    }
}
