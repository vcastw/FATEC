using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Teste {
    class Program {
        static void Main(string[] args) {
        Console.WriteLine("Digite um numero: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write($"A raiz quadrada de no número {x} é {Math.Sqrt(x)}");
        }
    }
}