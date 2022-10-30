Console.WriteLine("Digite um numero: ");
int n = int.Parse(Console.ReadLine());
int maior = n;
int menor = n;
while(n > 0){
    if(n > maior){
        maior = n;
    }else if(n < menor){
        menor = n;
    }
    Console.WriteLine("Digite outro valor: ");
    n = int.Parse(Console.ReadLine());
}
Console.WriteLine($"Maior: {maior}");
Console.WriteLine($"Menor: {menor}");