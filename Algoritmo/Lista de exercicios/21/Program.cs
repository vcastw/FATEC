using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Teste {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite as quatro notas do aluno: ");
            double nota1 = double.Parse(Console.ReadLine());
            double nota2 = double.Parse(Console.ReadLine());
            double nota3 = double.Parse(Console.ReadLine());
            double nota4 = double.Parse(Console.ReadLine());

            double media = ((nota1 * 3)+(nota2 * 5)+(nota3*6)+(nota4*6)) / 20;

            if (media < 6) {
                Console.WriteLine($"Reprovado, média: {media}");
            }else{
                Console.WriteLine($"Aprovado, média: {media}");
            }
        }
    }
}   