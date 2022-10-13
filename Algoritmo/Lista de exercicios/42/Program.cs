using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Teste {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Qual tipo de operação? (1-Soma, 2-Subtracao, 3-Divisao, 4-Multiplicacao)");
            int operacao = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite dois numeros para operacao: ");
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            
            switch (operacao){
                case 1:
                double soma = n1 + n2;
                Console.WriteLine($"Soma: {soma}");
                break;
                case 2:
                double subtracao = n1 + n2;
                Console.WriteLine($"Subtracao: {subtracao}");
                break;
                case 3:
                if(n2 != 0){
                    double divisao = (n1 / n2);
                    Console.WriteLine($"Divisao: {divisao}"); 
                }else{
                    Console.WriteLine("Valor invalido");
                }
                break;
                case 4:
                double multiplicacao = n1 * n2;
                Console.WriteLine($"Multiplicacao: {multiplicacao}");
                break;
                default:
                Console.WriteLine("Valor invalido");
                break;
            }
        }
    }
}