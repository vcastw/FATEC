﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Teste {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Qual altura ira subir? (em Metros):");
            double altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Qual altura do degrau da escada? (em Centimetros):");
            double degrau = double.Parse(Console.ReadLine());
            double quantidade = (altura / (degrau / 100));
            Console.WriteLine($"Serao {quantidade} degraus!");  
        }
    }
}   