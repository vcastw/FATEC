Console.WriteLine("Digite o valor da maior diagonal:");
double dMaior = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor da menor diagonal:");
double dMenor = double.Parse(Console.ReadLine());
if (dMaior < 1){
    Console.WriteLine("Valores invalidos");
}else if(dMenor < 1) {
    Console.WriteLine("Valores invalidos");
}else{
    double area = (dMaior * dMenor) / 2;
    Console.WriteLine($"Area: {area}");
}
