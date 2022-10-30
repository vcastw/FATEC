Console.WriteLine("Valor do salario minimo: ");
double sMinimo = double.Parse(Console.ReadLine());
Console.WriteLine("Consumo em quilowatt: ");
double gasto = double.Parse(Console.ReadLine());

double qGasto = sMinimo / 7;
double qUnitario = qGasto / 100;

Console.WriteLine($"O valor em reais de cada quilowatt: {qUnitario}");
Console.WriteLine($"Valor a ser pago: {qUnitario*gasto}");
double desconto = ((qUnitario*gasto) * 0.10);
Console.WriteLine($"Valor a ser pago com desconto de 10%: {qUnitario*gasto-desconto}");