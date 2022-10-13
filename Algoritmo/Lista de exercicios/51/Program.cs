using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Teste {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite um número menor que dez: ");
            int n = int.Parse(Console.ReadLine());
            int i = 20;
            if (n < 10){
                while(n <= i){
                    Console.WriteLine(i);
                    i= i-1;
                }
            }else{
                Console.WriteLine("Número invalido.");
            }
        }
    }
}