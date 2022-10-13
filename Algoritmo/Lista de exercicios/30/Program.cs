using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Teste {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite a temperatura em graus Celsius:");
            double C = double.Parse(Console.ReadLine());
            double F = C*(9.0/5.0)+32.0;
            Console.WriteLine($"Temperatura convertida em graus Fahrenheit: {F}");
        }
    }
}   