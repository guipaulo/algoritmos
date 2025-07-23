using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace registros2207
{
    internal class Program
    {   
        struct Funcionario
        {
            public string id;
            public string nome;
            public string funcao;
            public double salario;
        }
        static void Main(string[] args)
        {
            Funcionario[] funcionarios = new Funcionario[5];

            for(int i = 0; i<=4;  i++)
            {
                Console.WriteLine("Informe o id do funcionário: ");
                funcionarios[i].id = Console.ReadLine();
                Console.WriteLine("Informe o nome do funcionário: ");
                funcionarios[i].nome = Console.ReadLine();
                Console.WriteLine("Informe a função do funcionário: ");
                funcionarios[i].funcao = Console.ReadLine();
                Console.WriteLine("Informe o salário do funcionário: ");
                funcionarios[i].salario = Convert.ToDouble(Console.ReadLine());
            }

            for(int i = 0; i <= 4; i++)
            {
                Console.WriteLine("ID do funcionário: " + funcionarios[i].id);
                Console.WriteLine("Nome do funcionário: " + funcionarios[i].nome);
                Console.WriteLine("Função do funcionário: " + funcionarios[i].funcao);
                Console.WriteLine("Salário do funcionário: " + funcionarios[i].salario + "\n");
            }
        }
    }
}
