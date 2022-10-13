using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Teste {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Valor do produto:");
            double valor = double.Parse(Console.ReadLine());
            if (valor < 1){
                Console.WriteLine("Valor invalido");
            }else{
                double desconto = valor - (valor * 0.09);
                Console.WriteLine($"Valor com 9% de desconto: {desconto}");
            }
        }
    }
}