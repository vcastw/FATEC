﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Teste {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Digite tres numeros: ");
            double n1 = double.Parse(Console.ReadLine());
            double n2 = double.Parse(Console.ReadLine());
            double n3 = double.Parse(Console.ReadLine());

            double media = (n1 + n2 + n3) / 3;

            if (media < 7.50){
                Console.WriteLine($"Reprovado, media: {media}");
            }else{
                Console.WriteLine($"Aprovado, media: {media}"); 
            }
        }
    }
}   