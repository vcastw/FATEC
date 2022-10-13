using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Teste {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite três notas: ");
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            double n3 = double.Parse(Console.ReadLine());
            Console.WriteLine("Tipo de media (1-Aritmetica, 2-Ponderada): ");
            int tipo = int.Parse(Console.ReadLine());
            double media = 0;
            switch(tipo){
                case 1:
                media = (n1+n2+n3) / 3;
                Console.WriteLine($"Media Aritmetica: {media}");
                break;
                case 2:
                media = ((3*n1)+(3*n2)+(4*n3))/(3+3+4);
                Console.WriteLine($"Media Ponderada: {media}");
                break;
                default:
                Console.WriteLine("Numero invalido");
                break;
            }
        }
    }
}