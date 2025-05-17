using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aluguel_veiculo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  A Locadora de Veículos Eudora lançou uma grande promoção esse mês: pagando apenas R$ 90 por diária, 
             *  o cliente pode alugar um carro de passeio. Para cada diária, o cliente recebe uma cota de quilometragem
             *  de 100 Km. Cada quilômetro a mais custará uma taxa extra de R$ 12.

                Escreva um programa que receba como entrada a quantidade de dias e a quilometragem 
                total rodada por um cliente dessa locadora e exiba o valor total a ser pago.
             */

            int dias;
            int km;
            int totalDiaria;
            
            Console.WriteLine("Por quantos dias deseja alugar o veículo: ");
            dias = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Quantos km você percorreu: ");
            km = Convert.ToInt32(Console.ReadLine());

            if (km <= 100) 
            {
                totalDiaria = (90*dias);
                Console.WriteLine("Diária: " + totalDiaria);
            }
            else
            {
                totalDiaria = (90 * dias) + 12 * (km - 100);
                Console.WriteLine("Diária: " + totalDiaria);
            }
        }
    }
}
