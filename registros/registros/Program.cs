using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace registros
{
    internal class Program
    {
        struct Pessoa
        {
            public string nome;
            public double altura;
            public string cpf;
        }
        static void Main(string[] args)
        {
            Pessoa pessoa1;
            pessoa1.nome = "Paulo Guilherme";
            pessoa1.altura = 1.76;
            pessoa1.cpf = "70090471466";

            Pessoa[] pessoas = new Pessoa[3];
            pessoas[0].nome = "Carlos";
            pessoas[0].altura = 1.55;
            pessoas[0].cpf = "47815684100";

            pessoas[1].nome = "Luis";
            pessoas[1].altura = 1.85;
            pessoas[1].cpf = "85846593677";
            Console.WriteLine("");

            pessoas[2].nome = "Paulo";
            pessoas[2].altura = 2.01;
            pessoas[2].cpf = "55587841500";

            for (int i = 0; i <= 2; i++)
            {
                Console.WriteLine(pessoas[i].nome);
                Console.WriteLine(pessoas[i].altura);
                Console.WriteLine(pessoas[i].cpf);
            }
        }
    }
}
