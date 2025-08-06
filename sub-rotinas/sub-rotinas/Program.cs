using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sub_rotinas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sal, aum, novoSal;
            Console.WriteLine("Digite o salário: ");
            sal = Convert.ToDouble(Console.ReadLine());
            aum = Calculo(sal);
            novoSal = sal + aum;
            Console.WriteLine("O novo salário é: " + novoSal);
        }

        static double Calculo(double sal)
        {
            double perc, valor;
            Console.WriteLine("Digite o percentual de aumento: ");
            perc = Convert.ToDouble(Console.ReadLine());
            valor = sal * perc / 100;

            return valor;

        }
    }
}
