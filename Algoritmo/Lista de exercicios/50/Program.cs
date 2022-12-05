Console.WriteLine("Digite um número maior que zero: ");
int n = int.Parse(Console.ReadLine());
int i = 0;
if (n > 0){
    while(i<n){
        Console.WriteLine(i);
        i++;
    }
}else{
    Console.WriteLine("Número invalido.");
}