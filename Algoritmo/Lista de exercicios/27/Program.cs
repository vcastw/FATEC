Console.WriteLine("Digite um numero:");
double num = double.Parse(Console.ReadLine());
if(num > 1){
    double elevado = Math.Pow(num, 4);
    if(elevado % 2 == 0 && elevado % 5 == 0){
        Console.WriteLine($"O número digitado foi: {num}");
        Console.WriteLine($"Seu valor elevado ao quadro é: {Math.Pow(num,2)}");
        Console.WriteLine($"Seu valor elevado ao cubo é: {Math.Pow(num,3)}");
        Console.WriteLine($"Seu valor elevado a setima é: {Math.Pow(num,7)}");
    }else if (elevado % 2 != 0){
        Console.WriteLine($"O número digitado foi: {num}");
        Console.WriteLine($"Sua raiz quadrada é: {Math.Round(Math.Sqrt(num),2)}");
        Console.WriteLine($"Sua raiz cúbica é: {Math.Round(Math.Pow(num, 1.0/3.0),2)}");
        Console.WriteLine($"Sua raiz a sétima é: {Math.Round(Math.Pow(num, 1.0/7.0),2)}");
    }
}else{
    Console.WriteLine("Erro, numero invalido!");
}