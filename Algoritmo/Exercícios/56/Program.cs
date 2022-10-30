Console.WriteLine("Digite um número: ");
int x = int.Parse(Console.ReadLine());
int n = 1;
Console.WriteLine($"O numero {x} elevado ao quadrado é {Math.Pow(x,2)}.");
Console.WriteLine("");
while(n<5){
    n++;
    Console.WriteLine("Digite outro numero: ");
    x = int.Parse(Console.ReadLine());
    Console.WriteLine($"O numero {x} elevado ao quadrado é {Math.Pow(x,2)}.");
    Console.WriteLine("");
}