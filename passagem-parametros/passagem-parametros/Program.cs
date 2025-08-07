using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace passagem_parametros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Passagem por valor
            string Nome = "Maria";
            Imprimir(Nome);

            // Passagem por referência
            string Nome2 = "Maria";
            Imprima(ref Nome2);

            Console.WriteLine(Nome2);
        }

        static void Imprimir(string n)
        {
            Console.WriteLine(n);

            n = "João";
        }

        static void Imprima(ref string n2)
        {
            Console.WriteLine(n2);

            n2 = "João";
        }
    }
}
