using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Teste {
    class Program {
        static void Main(string[] args) {
        Console.WriteLine("Digite o valor do raio: ");
        double raio = double.Parse(Console.ReadLine());
        Console.WriteLine($"Area da circunferencia: {3.14 * Math.Pow(raio,2)}");
        Console.WriteLine($"Perimetro da circuferencia: {2 * 3.14 * raio}");
        }
    }
}