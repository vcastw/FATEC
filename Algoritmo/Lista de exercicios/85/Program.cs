int i = 0;
Console.WriteLine("Digite o valor limite: ");
int n = int.Parse(Console.ReadLine());

for(i = 1; i <= n; i++){
    if(i % 2 != 0){
        Console.WriteLine(i);
    }
}