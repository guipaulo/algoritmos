using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {// 
            double n1, n2;
            char operacao;

            Console.WriteLine("Menu de opção");
            Console.WriteLine(" + para operação de soma");
            Console.WriteLine(" - para operação de subtração ");
            Console.WriteLine(" * para operação de multiplicação");
            Console.WriteLine(" / para operação de divisão");
            Console.WriteLine(" Informe a operação desejada: ");

            operacao = Convert.ToChar(Console.ReadLine());

            switch(operacao)
            {
                case '+':
                    Console.WriteLine("Digite um número: ");
                    n1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite outro número: ");
                    n2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(" O resultado da operação é: " + (n1 + n2));
                    break;

                case '-':
                    Console.WriteLine("Digite um número: ");
                    n1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite outro número: ");
                    n2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(" O resultado da Operação é: " + (n1-n2));
                    break;

                case '*':
                    Console.WriteLine("Digite um número: ");
                    n1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite outro número: ");
                    n2 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(" O resultado da operação é: " + (n1 *  n2));
                    break;

                case '/':
                    Console.WriteLine("Digite um número: ");
                    n1 = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Digite outro número: ");
                    n2 = Convert.ToDouble(Console.ReadLine());
                    if (n2==0)
                    { 
                        Console.WriteLine(" Não é possível executar esta operação");
                    }
                    else
                    {
                        Console.WriteLine("O resultado da operação é:" + (n1 / n2));
                    }
                       
                    break;

            }

        }//
    }
}
