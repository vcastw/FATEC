﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Teste {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite um numero: ");
            double n1 = double.Parse(Console.ReadLine());

            if (n1 % 2 != 0){
                Console.WriteLine($"Impar, elevado ao cubo: {Math.Pow(n1,3)}");
            }else{
                Console.WriteLine($"Par, elevado ao quadrado: {Math.Pow(n1,2)}");
            }
        }
    }
}   