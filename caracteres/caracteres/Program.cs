using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization.Advanced;

namespace caracteres
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exemplo de declaração char
            char sexo;
            sexo = 'F';
            string nome;

            if(sexo == 'F')
            {
                Console.WriteLine("Sexo Feminino");
            }
            else
            {
                Console.WriteLine("Sexo Masculino");
            }

            //Declaração string
            nome = "Paulo";
            Console.WriteLine("Nome: " + nome);
            
            //Fatiamento de strings
            string nome2 = "Carlos";
            Console.WriteLine(nome[3]);

            //Comparação de strings
            string nome3 = "Paulo";
            string nome4 = "Carlos";
            string nome5 = "Lucas";
            string nome6 = "Lucas";

            if (nome3 != nome4) {
                Console.WriteLine("Os nomes não são iguais!");
            }

            if (nome5.Equals(nome6))
            {
                Console.WriteLine("Os nome são iguais");
            }

            //Número de caracteres numa cadeia
            string nome7 = "João";
            Console.WriteLine(nome7 + " possui " + nome7.Length + " caracteres");

            //Checar de um trecho encontra-se na cadeia
            string nome8 = "Paulo Silva Bastos";
            string trecho = "Silva";
            if (nome8.Contains(trecho))
            {
                Console.WriteLine("O trecho " + trecho + " encontra-se no nome " + nome8);
            }

            //Posição do trecho de caracteres
            int posicao = nome8.IndexOf(trecho);

            Console.WriteLine("A posição inicial de " + trecho + " no nome " + " é " + posicao);

            //Apgar o techo de um caracter
            nome8 = nome8.Remove(5, 9);
            Console.WriteLine(nome8);

            //Excluir um trecho de caracteres
            string trecho2 = nome8.Substring(5);
            Console.WriteLine(trecho2);

            //Concatenação
            string primeiroNome = "Paulo ";
            string segundoNome = "Guilherme";

            string nomeCompleto = primeiroNome + segundoNome;
            Console.WriteLine(nomeCompleto);

            //Substituição de palavras
            string disciplina = "Eu gosto de estudar Matemática";
            string procurado = "Matemática";
            string substituto = "Programação";
            disciplina = disciplina.Replace(procurado, substituto);
            Console.WriteLine(disciplina);
        }
    }
}
