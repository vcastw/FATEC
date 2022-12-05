Console.WriteLine("Digite o Sexo (M ou F): ");
char sexo = char.Parse(Console.ReadLine());
Console.WriteLine("Digite a altura da pessoa em metros: ");
double altura = double.Parse(Console.ReadLine());
double pesoI = 0;
switch(sexo){
    case 'M':
    pesoI = (72.7 * altura) - 58;
    Console.WriteLine(pesoI);
    break;
    case 'F':
    pesoI = (62.1 * altura) - 44.7;
    Console.WriteLine(pesoI);
    break;
    default:
    Console.WriteLine("Valor inválido!");
    break;
}