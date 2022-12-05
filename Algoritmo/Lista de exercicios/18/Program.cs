Console.WriteLine("Raio da circunferencia maior: ");
double raioMaior = double.Parse(Console.ReadLine());
Console.WriteLine("Raio da circunferencia menor:");
double raioMenor = double.Parse(Console.ReadLine());
double areaMaior = 3.14 * Math.Pow(raioMaior,2);
double areaMenor = 3.14 * Math.Pow(raioMenor,2);
Console.WriteLine($"Volume: {areaMaior - areaMenor}");
