using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Teste {
    class Program {
        static void Main(string[] args) {
        Console.WriteLine("Valor da area da base: ");
            double areab = double.Parse(Console.ReadLine());
        Console.WriteLine("Valor da altura: ");
            double altura = double.Parse(Console.ReadLine());
        Console.WriteLine($"Volume {areab * altura}");
        }
    }
}