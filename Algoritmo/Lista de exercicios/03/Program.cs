using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Teste {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite dois nomes: ");
            string nomeA = Console.ReadLine();
            string nomeB = Console.ReadLine();
            Console.WriteLine("Nomes na ordem que foram digitados: "+nomeA+" e "+nomeB);
            Console.WriteLine("Nomes na ordem inversa que foram digitados: "+nomeB+" e "+nomeA);
        }
    }
}