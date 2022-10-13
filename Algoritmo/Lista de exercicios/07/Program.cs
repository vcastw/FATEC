using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Teste {
    class Program {
        static void Main(string[] args) {
        Console.WriteLine("Digite um número inteiro: ");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine($"O número digitado foi {x}, seu antecessor é {x-1} e seu sucessor é {x+1}.");
        }
    }
}