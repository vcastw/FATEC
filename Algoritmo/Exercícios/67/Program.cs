Console.WriteLine("Digite um valor (x): ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Digite outro valor (y): ");
int y = int.Parse(Console.ReadLine());
if(x >= 1 && y >= 1){
    if(x <= 100 && y <= 100){
        do{
            if(x > y){
                Console.WriteLine($"Maior: {x}\nMenor {y}");
            }else{
                Console.WriteLine($"Maior: {y}\nMenor: {x}");
            }
            Console.WriteLine("Digite um valor (x): ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite outro valor (y): ");
            y = int.Parse(Console.ReadLine());
        }while(x >= 1 && x <= 100 || y >= 1 && y <= 100);
    }
}else{
    Console.WriteLine("Fim do programa, digitou um numero menor igual a 0 ou um número maior que 100.");
}
