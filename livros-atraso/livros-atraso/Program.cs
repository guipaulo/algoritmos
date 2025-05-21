using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace livros_atraso
{
    internal class Program
    {
        static void Main(string[] args)
        { /*
           * A biblioteca de Rio Tinto empresta gratuitamente seus livros 
           * a alunos, professores e funcionários de todo o campus. Entretanto, sempre que um usuário atrasa 
           * a entrega de um livro, ele tem que pagar uma multa de R$ 0,75 por cada dia de atraso.
           * Escreva um programa que receba como entrada a quantidade de dias de atraso do empréstimo 
           * de um livro, e exiba o valor da multa a ser paga pelo usuário.
          */

            int diasAtraso = 0;

            double valorMulta = 0;

            Console.WriteLine("Dias de atraso: ");
            diasAtraso = Convert.ToInt32(Console.ReadLine());

            valorMulta = 0.75 * diasAtraso;

            Console.WriteLine("A multa será de: " + valorMulta);
        }
    }
}
