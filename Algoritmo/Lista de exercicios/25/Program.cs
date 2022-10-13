using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Teste {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Cateto oposto(altura): ");
            double cA = double.Parse(Console.ReadLine());
            if(cA <0){
                Console.WriteLine("Numero negativo, invalido!");
            }else{
                Console.WriteLine("Cateto adjacente(base): ");
                double cB = double.Parse(Console.ReadLine());
                if(cB < 0){
                    Console.WriteLine("Numero negativo, invalido!");
                }else{
                    double hipotenusa = Math.Pow(cA,2) + Math.Pow(cB, 2);
                    double area = (cB * cA) / 2;
                    Console.WriteLine($"Hipotenusa {hipotenusa}");
                    Console.WriteLine($"Area: {area}");
                }
            }
        }
    }
}   