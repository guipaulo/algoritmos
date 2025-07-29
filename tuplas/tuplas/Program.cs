using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace tuplas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Formas de criar Tuplas:
            var tupla2 = new Tuple<string, int>("Meu texto", 7);
            var tupla3 = Tuple.Create<string, int>("Meu texto", 7);
            (string, int) tupla4 = ("Meu texto", 7);
            var tupla5 = ("Meu texto", 7);

            // Tuplas nomeadas:
            var tupla6 = (Nome: "João", Idade: 25);
            Console.WriteLine(tupla6.Nome);

            (string Nome, int numero) tupla7 = ("Meu texto", 7);
            Console.WriteLine(tupla7.Nome);
            Console.WriteLine(tupla7.numero);

            // Vetor de tuplas:
            var pessoas = new (string nome, int idade, bool Ativo)[]
            {
                ("João", 25, true),("Maria", 18, false)
            };

            Console.WriteLine(pessoas[0].nome);
            Console.WriteLine(pessoas[1].idade);
        }
    }
}
