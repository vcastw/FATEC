using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Teste {
    class Program {
        static void Main(string[] args) {
        Console.WriteLine("Digite o valor área da circunferencia: ");
            double areaBase = double.Parse(Console.ReadLine());
        Console.WriteLine("Altura:");
            double altura = double.Parse(Console.ReadLine());
        Console.WriteLine($"Volume: {areaBase * altura}");
        }
    }
}