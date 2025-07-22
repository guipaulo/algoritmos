using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caracteres2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome1 = "Paulo";
            string nome2 = "Guilherme";
            string nome3 = "Paulo";
            string nome4 = "Gustavo";
            string nome5 = "Marina Soares da Silva";
            string nome6 = "Ellen Mayara";

            string trecho = "Gui";
            string trecho2 = "Soares";

            if (nome1 == nome2)
            {
                Console.WriteLine("Os nomes são iguais");
            }
            else
            {
                Console.WriteLine("Os nomes são diferentes");
            }

            if(nome1.Equals(nome3))
            {
                Console.WriteLine("Os nomes são iguais");
            }

            Console.WriteLine("O nome " + nome4 + " tem " + nome4.Length + " letras ");

            if (nome2.Contains(trecho))
            {
                Console.WriteLine("O trecho " + trecho + " está contido em " + nome2);
            }

            int posicao = nome5.IndexOf(trecho2);
            Console.WriteLine("A posição inicial de " + trecho2 + " no nome " + nome5 + " é " + posicao);

            nome6 = nome6.Remove(0, 6);
            Console.WriteLine(nome6);

            string trecho3 = nome6.Substring(5);
            Console.WriteLine(trecho3);

            string frase = "Eu gosto de estudar matemática";
            string textoProcurado = "matemática";
            string textoNovo = "programação";

            frase = frase.Replace(textoProcurado, textoNovo);
            Console.WriteLine(frase);
        }


    }
}
