using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Teste {
    class Program {
        static void Main(string[] args) {
        Console.WriteLine("Raio da esfera: ");
            double raio = double.Parse(Console.ReadLine());
        Console.WriteLine($"Area: {4*3.14*(Math.Pow(raio,2))}");
        Console.WriteLine($"Volume: {(4/3)*3.14*(Math.Pow(raio,3))}");
        }
    }
}   