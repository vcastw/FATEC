int x;
int y;
int z;
do
{
    Console.WriteLine("Digite um valor maior que zero: ");
    x = int.Parse(Console.ReadLine());
    if(x == 0 ){
        Console.WriteLine("Valor não pode ser igual a zero.");
    }else if(x % 2 == 0 ){
        y = x + 5;
        Console.WriteLine($"Par, {y}");
    }else{
        z = x + 8;
        Console.WriteLine($"Ímpar, {z}");
    }
} while (x >= 1);