using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Teste {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite três números:");
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double num3 = double.Parse(Console.ReadLine());

            double soma = Math.Pow(num1,2) + Math.Pow(num2,2) + Math.Pow(num3,2);

            if(soma % 2 == 0){
                Console.WriteLine($"A soma dos quadrados dos três valores lidos é: {soma}, ela é par");    
            }else{
                Console.WriteLine($"A soma dos quadrados dos três valores lidos é: {soma}, ela é ímpar");
            }
        }
    }
}   