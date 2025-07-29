using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace listas_csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List <int> list = new List<int>();

            // Adicionar elementos na lista
            list.Add (1);
            list.Add (2);
            list.Add (3);

            Console.WriteLine(list[0]);
            Console.WriteLine(list[1]);

            Console.WriteLine();

            List<int> list2 = new List<int>();
            list2.Add (2);
            list2.Add (3);
            list2.Add(4);
            list2.Add(5);
            
            Console.WriteLine(list2.Count() + " itens"); // Contar os elementos da lista
            Console.WriteLine(list2.IndexOf(3)); // Retornar a posição de um elemento da lista

            Console.WriteLine();

            List<int> list3 = new List<int>();

            list3.Add (3);
            list3.Add (1);
            list3.Add (2);
            list3.Add (7);
            list3.Add (5);

            Console.WriteLine(list3[0]);
            list3.Sort(); // Ordenar elementos da lista
            Console.WriteLine(list3[0]);

            Console.WriteLine();

            foreach (int i in list3) // Iterar elementos da lista (Ordenados)
            {
                Console.WriteLine(i);
            }
        }
    }
}
