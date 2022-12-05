int i = 0;
for(i = 0; i < 5; i++){
    Console.WriteLine("Digite um numero: ");
    double n = double.Parse(Console.ReadLine());
    Console.WriteLine(Math.Pow(n, 2));
}