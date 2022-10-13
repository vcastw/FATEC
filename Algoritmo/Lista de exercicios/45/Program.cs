using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Teste {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite o peso (Kilos) da pessoa: ");
            double peso = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite a altura (Metros) da pessoa: ");
            double altura = double.Parse(Console.ReadLine());
            double imc = peso / Math.Pow(altura, 2);
            if(peso != null && altura != null){
                if(imc < 17){
                    Console.WriteLine("Muito abaixo do peso");
                }else if(imc >= 17 && imc <= 18.49){
                    Console.WriteLine("Abaixo do peso");
                }else if(imc >= 18.5 && imc <= 24.99){
                    Console.WriteLine("Peso normal");
                }else if(imc >= 25 && imc <= 29.99){
                    Console.WriteLine("Acima do peso");
                }else if(imc >= 30 && imc <= 34.99){
                    Console.WriteLine("Obesidade I");
                }else if(imc >= 35 && imc <= 39.99){
                    Console.WriteLine("Obesidade II");
                }else{
                    Console.WriteLine("Obesidade III");
                }
            }else{
                Console.WriteLine("Os valores não podem ser nulos!");
            }
        }
    }
}