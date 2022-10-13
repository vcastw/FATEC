using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Teste {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite tres numeros:");
            double num1 = double.Parse(Console.ReadLine());
            double num2 = double.Parse(Console.ReadLine());
            double num3 = double.Parse(Console.ReadLine());
            /*Verifica o numero 1*/
            if(num1 == 0){
                Console.WriteLine($"{num1} é neutro");
            }else if(num1 > 1){
                Console.WriteLine($"{num1} é positivo");
            }else{
                Console.WriteLine($"{num1} é negativo");
            }
            /*Verifica o numero 2*/
            if(num2 == 0){
                Console.WriteLine($"{num2} é neutro");
            }else if(num2 > 1){
                Console.WriteLine($"{num2} é positivo");
            }else{
                Console.WriteLine($"{num2} é negativo");
            }
            /*Verifica o numero 3*/
            if(num3 == 0){
                Console.WriteLine($"{num3} é neutro");
            }else if(num3 > 1){
                Console.WriteLine($"{num3} é positivo");
            }else{
                Console.WriteLine($"{num3} é negativo");
            }
            /*Maior numero*/
            if(num1 > num2 && num1 > num3){
                Console.WriteLine($"{num1} é o maior numero");
            }else if(num2 > num1 && num2 > num3){
                Console.WriteLine($"{num2} é o maior numero");
            }else{
                Console.WriteLine($"{num3} é o maior numero"); 
            }
        }
    }
}   