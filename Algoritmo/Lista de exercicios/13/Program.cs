Console.WriteLine("Digite quatro numeros: ");
double a = double.Parse(Console.ReadLine());
double b = double.Parse(Console.ReadLine());
double c = double.Parse(Console.ReadLine());
double d = double.Parse(Console.ReadLine());
Console.Write($"Media Ponderada: {(a*1+b*2+c*3+d*4)/(1+2+3+4)}");
