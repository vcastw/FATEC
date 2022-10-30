Console.WriteLine("Qual tipo de sorvete quer comprar? (1, 2 ou 3)");
double tipo = double.Parse(Console.ReadLine());
Console.WriteLine("Quantidade desejada");
double quantidade = double.Parse(Console.ReadLine());
double preco = 0;
switch(tipo){
    case 1:
        preco = 1.50;
        break;
    case 2:
        preco = 2.60;
        break;
    case 3:
        preco = 3.75;
        break;
    default: 
        Console.WriteLine("Valor invalido!");
        break;
}
double pagar = preco * quantidade;
Console.WriteLine($"Tipo escolhido: {tipo}\nQuantidade: {quantidade}\nPreço do produto: {preco}\nValor total: {pagar}");