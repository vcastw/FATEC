Console.WriteLine("Digite dois numeros:");
double n1 = double.Parse(Console.ReadLine());
double n2 = double.Parse(Console.ReadLine());

double adicao = n1 + n2;

if(adicao > 10){
    Console.WriteLine($"Numero digitados: {n1} e {n2}");
    Console.WriteLine($"Valor da adição: {adicao}");
    Console.WriteLine($"Raiz cubica: {(Math.Sqrt(adicao/3))}");
}else{
    Console.WriteLine($"Numero digitados: {n1} e{n2}");
    Console.WriteLine($"Valor da adição: {adicao}");
}