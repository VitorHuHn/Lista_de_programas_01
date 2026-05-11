using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double m1;
            double m2;
            double m3;
            double m4;
            double media;


            Console.Write("Digite o Primeiro Num: ");
            m1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o Segundo Num: ");
            m2 = double.Parse(Console.ReadLine());

            Console.Write("Digite o Terceiro Num: ");
            m3 = int.Parse(Console.ReadLine());

            Console.Write("Digite o Quarto Num: ");
            m4 = double.Parse(Console.ReadLine());

            media = (m1 + m2 + m3 + m4) / 4;

            Console.Write("A Média dos 4 números é: {0} ", media);
        }
    }
}
