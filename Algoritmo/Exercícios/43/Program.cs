﻿Console.WriteLine("Digite um numero: ");
double num1 = double.Parse(Console.ReadLine());
if(num1 > 0){
    Console.WriteLine($"Numero digitado: {num1}, sua raiz quadrada: {Math.Sqrt(num1)}");
}else{
    Console.WriteLine($"Numero digitado: {num1}, seu valor elevado ao quadrado {Math.Pow(num1, 2)}");
}
