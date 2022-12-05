Console.WriteLine("Digite o número máximo");
int qtd = int.Parse(Console.ReadLine());
int i;
int produto = 1;
for (i = 1; i <= qtd; i++){
    Console.WriteLine(i);
    produto = produto * i;
}
Console.WriteLine($"Produto dos números {produto}");