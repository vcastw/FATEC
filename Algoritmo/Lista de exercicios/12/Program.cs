using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Teste {
    class Program {
        static void Main(string[] args) {
        Console.WriteLine("Digite um numero: ");
        double x = double.Parse(Console.ReadLine());
        Console.Write($"O número digitado foi {x}\n Suu raiz cubica é {Math.Pow(x, 1.0/3.0)}\n Sua raiz quadrada é {Math.Sqrt(x)}");
        }
    }
}