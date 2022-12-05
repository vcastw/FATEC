int qtdPar = 0;
int qtd = 0;
int i = 0;
Console.WriteLine("Quantos?");
qtd = int.Parse(Console.ReadLine());
for(i = 2; i <1000; i++ ){
    if(i % 2 == 0){
        qtdPar += 1;
        Console.WriteLine(i);
    }
    if(qtdPar == qtd){
        break;
    }
}