int i = 1000;
int m = 0;
while(i != 0){
    if(i % 3 == 0 && i % 5 == 0){
        m += i;
    }
    i--;
}
Console.WriteLine($"Soma do multiplos de 3 e 5: {m} ");