Console.WriteLine("Digite o valor da maior diagonal:");
double dMaior = double.Parse(Console.ReadLine());
Console.WriteLine("Digite o valor da menor diagonal:");
double dMenor = double.Parse(Console.ReadLine());
if (dMaior < 1){
    Console.WriteLine("Valores invalidos");
}else if(dMenor < 1) {
    Console.WriteLine("Valores invalidos");
}else{
    double lado = Math.Pow((dMaior/2),2) + Math.Pow((dMenor/2),2);
    Console.WriteLine($"Valor do seu lado: {lado}");
}