using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula002
{
    internal class ExStack
    {
            public static void Run()
            {
                Stack<string> numeros = new Stack<string>();

                numeros.Push("um");
                numeros.Push("dois");
                numeros.Push("três");
                numeros.Push("quatro");
                numeros.Push("cinco");

                foreach (string numero in numeros)
                {
                    Console.WriteLine(numero);
                }
            }
        }
    }
