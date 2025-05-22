using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace administradora_cartao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * Uma administradora de cartões está oferecendo uma promoção aos seus clientes.
             *  A pessoa que não puder pagar o total da fatura no mês de março, poderá pagar
             *  apenas 50% do valor, e o restante poderá ser pago no mês seguinte com juros de 6,5%.
             *  Desenvolva uma solução para ajudar o cliente a descobrir qual será o valor de sua fatura 
             *  no mês de abril caso ele aceite a proposta. 
             */

            double divida = 0;
            double pagMarco = 0;
            double pagAbril = 0;

            Console.WriteLine("Informe o valor de sua dívida: ");
            divida = Convert.ToDouble(Console.ReadLine());
            pagMarco = divida / 2;
            pagAbril = pagMarco * Math.Pow((1 + 0.065), 1);


            Console.WriteLine("O valor a ser pago em Março é " + pagMarco);
            Console.WriteLine("O valor a ser pago em Abril é " + pagAbril);
        }
    }
}
