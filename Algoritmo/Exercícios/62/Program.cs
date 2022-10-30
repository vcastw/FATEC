Console.WriteLine("Digite um número: ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Digite outro número: ");
int y = int.Parse(Console.ReadLine());

if (x > y){
    while(y != x){
        if(y % 2 == 0 && y % 7 == 0){
            Console.WriteLine($"Par e multiplo de 7: {y}");
        }
        y++;
    }
}else if(y > x){
    while(x != y){
        if(x % 2 == 0 && x % 7 == 0){
            Console.WriteLine($"Par e multiplo de 7: {x}");
        }
        x++;
    }
}else{
    Console.WriteLine("Nenhum numero par e multiplo de 7");
}