using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Teste {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite um numero:");
            double n = double.Parse(Console.ReadLine());
            double elevado = Math.Pow(n, 2);
            if(elevado > 10){
                Console.WriteLine($"Maior que 10, {elevado}, raiz cubica é {Math.Sqrt(n/3)}");
            }else if(elevado == 10){
                Console.WriteLine("Igual a 10");
            }else{
                Console.WriteLine("Menor que 10");
            }
        }
    }
}