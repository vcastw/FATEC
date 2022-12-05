Console.WriteLine("Digite o valor do salario:");
double salario = double.Parse(Console.ReadLine());
double porcentagem = salario*0.25;
Console.WriteLine($"Salario: {salario} \nSalario com 25% de aumento: {salario+porcentagem}");