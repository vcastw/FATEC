Console.WriteLine("Digite o lado do quadrado: ");
int lado = int.Parse(Console.ReadLine());
double area = Math.Pow(lado, 2);
double perimetro = lado * 4;
Console.WriteLine($"Area: {area} e Perimetro: {perimetro}");
