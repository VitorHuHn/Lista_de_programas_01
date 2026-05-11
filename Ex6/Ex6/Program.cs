using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n1;
            double n2;
            double nM;
            double mediaG;

            Console.Write("Digite o Primeiro Num: ");
            n1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o Segundo Num: ");
            n2 = double.Parse(Console.ReadLine());

            nM = n1 * n2;
            mediaG = Math.Sqrt(nM);

            Console.WriteLine("A Média Geométrica desses numeros é de: {0}", mediaG);

        }
    }
}
