using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Teste {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Nome do aluno: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Valor da primeira nota: ");
            double n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Valor da segunda nota: ");
            double n2 = double.Parse(Console.ReadLine());
            if(n1 > 0 && n1 < 10 && n2 > 0 && n2 < 10){
                Console.WriteLine($"Nome do aluno: {nome}");
                Console.WriteLine($"Notas do aluno: {n1} e {n2}");
                double media = (n1 + n2)/2;
                Console.WriteLine($"Media do aluno: {media}");
                if(media > 7){
                    Console.WriteLine("Aprovado");
                }else if(media < 5){
                    Console.WriteLine("Retido");
                }else{
                    Console.WriteLine("Recuperação");
                }
            }else{
                Console.WriteLine("ERRO");
            }
        }
    }
}