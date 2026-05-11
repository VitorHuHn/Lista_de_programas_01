using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int b;
            int a;
            int ar;

            Console.Write("Digite a base do retangulo: ");
            b = int.Parse(Console.ReadLine());

            Console.Write("Digite a altura do retangulo: ");
            a = int.Parse(Console.ReadLine());

            ar = b * a;

            Console.Write("Área do Retângulo: {0}" , ar);
               

        }
    }
}
