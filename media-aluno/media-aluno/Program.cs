using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace media_aluno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3;
            double media;

            Console.WriteLine("Digite a nota 1");
            nota1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a nota 2");
            nota2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a nota 3");
            nota3 = Convert.ToDouble(Console.ReadLine());

            media = (nota1 + nota2 + nota3) / 3;

            if(media >=7)
            {
                Console.WriteLine("Aprovado");
                Console.WriteLine(media);
            }
            else
            {
                if (media >= 5 && media > 6.9)
                {
                    Console.WriteLine("Recuperação");
                    Console.WriteLine(media);
                }
                else
                {
                    if(media < 5)
                    {
                        Console.WriteLine("Reprovado");
                        Console.WriteLine(media);
                    }
                }
            }
        }
    }
}
