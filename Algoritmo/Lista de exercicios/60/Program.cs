int i = 100;
int soma = 0;
while(i != 0){
    i--;
    if(i % 2 == 0){
        if(i % 5 == 0){
            soma += i;
            Console.WriteLine ($"Par e multiplo de 5: {i}");
        }
        if(i % 7 == 0){
            soma += i;
            Console.WriteLine ($"Par e multiplo de 7: {i}");
        }
    }
}
Console.WriteLine($"Soma dos pares multiplos de 5 e 7: {soma}");