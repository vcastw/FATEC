int i = 0;
double x;
double div;
do{
    i++;
    Console.WriteLine("Digite um numero: ");
    x = int.Parse(Console.ReadLine());
    Console.WriteLine(" ");
    div = x / 2; 
    Console.WriteLine(div);
}while(i < 10);