int A;
int B;
int C;
do{
    Console.WriteLine("Digite um valor: ");
    A = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite um valor: ");
    B = int.Parse(Console.ReadLine());
    if( A >= 1)
    if(A == B || B == A){
        C = A + B;
        Console.WriteLine($"A + B: {C}");
    }else{
        C = A * B;
        Console.WriteLine($"A * B: {C}");
    } 
}while(A >= 1 && B >=1);