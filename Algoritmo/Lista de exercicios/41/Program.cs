using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Teste {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Salario:");
            double salario = double.Parse(Console.ReadLine());
            double aumento = (salario * 0.25) + salario;
            Console.WriteLine($"Salario atual: {salario}");
            Console.WriteLine($"Salario com 25% de aumento: {aumento}");
        }
    }
}