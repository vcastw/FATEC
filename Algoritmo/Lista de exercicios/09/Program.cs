using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Teste {
    class Program {
        static void Main(string[] args) {
        Console.WriteLine("Digite a base e altura do retangulo: ");
        double b = double.Parse(Console.ReadLine());
        double h = double.Parse(Console.ReadLine());
        double area = (b * h);
        double perimetro = (b*2) + (h*2);
        Console.WriteLine($"Area: {area}, Perimetro: {perimetro}");
        }
    }
}