using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Teste {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite dois numeros:");
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double adicao = num1 + num2;
            if(adicao > 10){
                Console.WriteLine($"Os numeros digitado foram {num1} e {num2}");
                Console.WriteLine($"Soma dos numeros: {adicao}");
                Console.WriteLine($"Raiz cubica da adicao: {Math.Round(Math.Pow(adicao, 1.0/3.0),2)}");
            }else{
                Console.WriteLine($"Os numeros digitado foram {num1} e {num2}");
                Console.WriteLine($"Soma dos numeros: {adicao}");
            }
        }
    }
}   