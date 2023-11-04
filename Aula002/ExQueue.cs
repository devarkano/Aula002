using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula002
{
    internal class ExQueue
    {
        public static void Run()
        {
            Queue<string> minhaFila = new Queue<string>();

            minhaFila.Enqueue("UEA");
            minhaFila.Enqueue("40000");
            minhaFila.Enqueue("2023");

            Console.WriteLine($"Quantidade : {minhaFila.Count}");
            Console.WriteLine("Valores: ");

            while(minhaFila.Count > 0)
            {
                Console.WriteLine(minhaFila.Dequeue());
            }
        }
    }
}
