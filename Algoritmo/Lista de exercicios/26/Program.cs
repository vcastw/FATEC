Console.WriteLine("Digite um numero: ");
double n = double.Parse(Console.ReadLine());
if(n <= 0){
    Console.WriteLine("Numero igual ou menor que zero, invalido");
}else{
    if(n % 2 == 0){
        Console.WriteLine("Par");
    }else{
        Console.WriteLine("Impar");
    }
}