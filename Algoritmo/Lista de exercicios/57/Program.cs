int contagem = 1;
int numero = 0;
int resultado = 0;

while(numero != 50){
    Console.WriteLine($"Testando {contagem}");
    if(contagem % 2 == 0){
        resultado += contagem;
        contagem++;
        numero++;
    }else{
        contagem++;
    }
}
Console.WriteLine($"Resultado {resultado}");