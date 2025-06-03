using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_for
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());

            for (int x = 1; x <= 10; x++) 
            {
                int resultado = num * x;
                Console.WriteLine(resultado);
        }   }
    }
}
