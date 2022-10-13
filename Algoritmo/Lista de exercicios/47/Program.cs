using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Teste {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite o codigo: ");
            int codigo = int.Parse(Console.ReadLine());
            Console.WriteLine("Quantidade: ");
            int quantidade = int.Parse(Console.ReadLine());
            string tipo = " ";
            double preco = 0;
            switch(codigo){
                case 100:
                tipo = "Cachorro quente";
                preco = 4.50;
                break;
                case 101:
                tipo = "Bauru simples";
                preco = 4.50;
                break;
                case 102:
                tipo = "Bauru c/ovo";
                preco = 5.50;
                break;
                case 103:
                tipo = "Hambúrguer";
                preco = 6.50;
                break;
                case 104:
                tipo = "Refrigerante";
                preco = 3.50;
                break;
                default:
                Console.WriteLine("Valor invalido");
                break;
            }
            double pagar = preco * quantidade;
            Console.WriteLine($"Valor a ser pago: R${pagar}");
        }
    }
}
