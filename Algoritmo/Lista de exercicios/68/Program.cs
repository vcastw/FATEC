int risco = 0;
do{
    Console.WriteLine($"Atual valor de risco: {risco}, normal. \nDigite o valor do alerta de risco: ");
    risco = int.Parse(Console.ReadLine());
        if(risco >= 0 && risco <= 10){
        
        }else{
        Console.WriteLine("Valor invalido!");
        }
}while(risco < 9);
    Console.WriteLine($"Risco nível {risco}: GRAVE!");