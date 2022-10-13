using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Teste {
    class Program {
        static void Main(string[] args) {
        Console.WriteLine("Digite um numero: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write($"O número digitado foi {x}, seu valor elevado a 2 é {Math.Pow(x,2)}, elevado a 3 é {Math.Pow(x,3)}");
        }
    }
}