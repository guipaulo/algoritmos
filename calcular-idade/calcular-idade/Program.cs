using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calcular_idade
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int anonasc, ano;

            Console.WriteLine("Digite o seu ano de nascimento: ");
            anonasc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o ano atual: ");
            ano = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sua idade é: " + (ano-anonasc));






        }
    }
}
