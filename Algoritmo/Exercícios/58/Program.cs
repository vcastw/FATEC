Console.WriteLine("Digite um numero: ");
double n = int.Parse(Console.ReadLine());
double soma = 0;
double somaPar = 0;
double qtd = 0;
double qtdPar = 0;

while(n != 0 ){
    if(n % 2 == 0){
        somaPar+= n;
        qtdPar++;
    }
    Console.WriteLine("Digite um numero: ");
    n = double.Parse(Console.ReadLine());
    qtd++;
    soma+= n;
}

Console.WriteLine($"Quantidade de numeros digitado: {qtd}");
Console.WriteLine($"Quantidade de numeros pares: {qtdPar}");
Console.WriteLine($"Media dos numeros digitados {soma/qtd}");
Console.WriteLine($"Media dos numeros pares: {somaPar/qtdPar}");