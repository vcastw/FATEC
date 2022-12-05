Console.WriteLine("Digite o valor limite: ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Digite um valor de incremento");
int y = int.Parse(Console.ReadLine());
int i = 0;
if(x > 0 && y > 0 ){
    while(i < x){
        Console.WriteLine(i);
        i += y;
    }
}else{
    Console.WriteLine("Número invalido, menor ou igual a zero.");
}