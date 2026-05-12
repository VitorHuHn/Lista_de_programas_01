using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex7
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double milhas;
            double milhasConv;
            double conv;

            conv = 1.852;

            Console.Write("Digite o valor das milhas marítimas: ");
            milhas = double.Parse(Console.ReadLine());

            milhasConv = milhas * conv;

            Console.Write("Essas milhas equivalem á {0} Km", milhasConv);

        }
    }
}
