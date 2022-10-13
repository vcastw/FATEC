using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Teste {
    class Program {
        static void Main(string[] args) {
            int i = 0;
            int c = 0;
            while(i <= 100){
                c+=i;
                i++;
            }
            Console.WriteLine(c);
        }
    }
}