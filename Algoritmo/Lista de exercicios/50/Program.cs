using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Teste {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite um número maior que zero: ");
            int n = int.Parse(Console.ReadLine());
            int i = 0;
            if (n > 0){
                while(i<n){
                    Console.WriteLine(i);
                    i++;
                }
            }else{
                Console.WriteLine("Número invalido.");
            }
        }
    }
}