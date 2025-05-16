using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculo_imc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Crie um programa que calcule o IMC de uma pessoa e informe, de acordo com o
             * valor do IMC se a pessoa está em baixo peso, peso adequado, sobrepeso ou em obesidade
             */

            double peso;
            double altura;
            double imc;

            Console.WriteLine("Digite sua altura (m): ");
            altura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite seu peso (kg): ");
            peso = Convert.ToDouble(Console.ReadLine());

            imc = peso / (altura * altura);

            if (imc < 18.5)
            {
                Console.WriteLine("Seu IMC é: " + imc);
                Console.WriteLine("\nBaixo peso");
            }
            if (imc >= 18.5 && imc <= 24.9)
            {
                Console.WriteLine("Seu IMC é: " + imc);
                Console.WriteLine("\nPeso adequado");
            }
            if (imc > 25 && imc <= 29.9)
            {
                Console.WriteLine("Seu IMC é: " + imc);
                Console.WriteLine("\nSobrepeso");
            }
            if (imc > 30 && imc <= 34.9)
            {
                Console.WriteLine("Seu IMC é: " + imc);
                Console.WriteLine("\nObesidade grau I");
            }
            if (imc > 35 && imc <= 39.9)
            {
                Console.WriteLine("Seu IMC é: " + imc);
                Console.WriteLine("\nObesidade grau II");
            }
            if (imc >= 40)
            {
                Console.WriteLine("Seu IMC é: " + imc);
                Console.WriteLine("\nObesidade grau III");
            }
        }
    }
}
