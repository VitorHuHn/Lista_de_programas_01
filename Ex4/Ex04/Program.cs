using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double b;
            double a;
            double h;

            Console.Write("Digite a altura de um triângulo: ");
            h = double.Parse(Console.ReadLine());

            Console.Write("Digite a base de um triângulo: ");
            b = double.Parse(Console.ReadLine());

            a = (h * b) / 2;

            Console.Write("A área do triângulo é: {0}", a);

        }
    }
}
