using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Teste {
    class Program {
        static void Main(string[] args) {
        Console.WriteLine("Digite cinco valores reais: ");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());
        double d = double.Parse(Console.ReadLine());
        double e = double.Parse(Console.ReadLine());
        Console.WriteLine("Os números digitados foram: "+a+", "+b+", "+c+", "+d+", "+e+".\n E sua soma é "+(a+b+c+d+e));
        }
    }
}