using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listas_tuplas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaração de uma tupla:
            var pessoa = ("João", 25, true);
            (string, int, bool) pessoa2 = ("João", 25, true);
            var pessoa3 = (Nome: "João", Idade: 25, Ativo: true);

            // Impressão de dados das tuplas
            Console.WriteLine(pessoa.Item1);
            Console.WriteLine(pessoa2.Item2);
            Console.WriteLine(pessoa3.Ativo);

            // Vetor de tuplas
            var pessoas = new (string nome, int idade, bool Ativo)[]
            {
                ("João", 25, true),
                ("Maria", 18, false)
            };

            // Impressão de vetor de tupla
            Console.WriteLine(pessoas[0].nome);
            Console.WriteLine(pessoas[1].idade);

            Console.WriteLine("\n");

            // Criação de listas
            List<string> carros = new List<string>();

            // Adicionando elementos na lista
            carros.Add("Golf");
            carros.Add("HRV");
            carros.Add("Focus");
            carros.Add("Argo");

            foreach (string car in carros)
            {
                Console.WriteLine("Carro: " + car);
            }
            Console.WriteLine("\n");

            Console.WriteLine(carros.Contains("HRV"));
            Console.WriteLine(carros.IndexOf("Argo"));
            Console.WriteLine(carros.Count());

            carros.Remove("Golf");
            foreach (string car in carros)
            {
                Console.WriteLine("Carro: " + car);
            }
            Console.WriteLine("\n");

            carros.RemoveAt(2);

            foreach (string car in carros)
            {
                Console.WriteLine("Carro: " + car);
            }
            Console.WriteLine("\n");
        }
    }
}
