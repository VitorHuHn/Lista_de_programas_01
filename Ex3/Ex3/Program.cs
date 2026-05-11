using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int diagonal;
            int d;

            Console.Write("Digite a diagonal de um quadrado: ");
            diagonal = int.Parse(Console.ReadLine());

            d = diagonal * diagonal ;

            Console.Write("A área do quadrado é: {0}", d);

        }
    }
}
