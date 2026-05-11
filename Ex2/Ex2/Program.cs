using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int aresta;
            int a;

            Console.Write("Digite a aresta de um quadrado: ");
            aresta = int.Parse(Console.ReadLine());

            a = aresta * aresta;

            Console.Write("A área do quadrado é: {0}", a);

        }
    }
}
