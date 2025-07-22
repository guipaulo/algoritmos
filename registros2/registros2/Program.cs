using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace registros2
{
    internal class Program
    {
        struct Aluno
        {
            public string matricula;
            public string nome;
            public string serie;

        }
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];

            for (int i = 0; i < alunos.Length; i++)
            {
                Console.WriteLine("Digite a matricula do aluno: ");
                alunos[i].matricula = Console.ReadLine();
                Console.WriteLine("Digite o nome do aluno: ");
                alunos[i].nome = Console.ReadLine();
                Console.WriteLine("Digite a série do aluno: ");
                alunos[i].serie = Console.ReadLine();
            }

            Console.WriteLine();

            for (int i = 0;i < alunos.Length;i++)
            {
                Console.WriteLine(alunos[i].matricula);
                Console.WriteLine(alunos[i].nome);
                Console.WriteLine(alunos[i].serie);
            }
            Console.WriteLine();
        }
    }
}
