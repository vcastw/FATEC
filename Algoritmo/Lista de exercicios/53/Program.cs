Console.WriteLine("Digite dois número diferentes: ");
int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());
int z;

if (x != y){
    if(x<y){
        while(x <= y){
            z= x++;
            Console.WriteLine(z);
        }
    }else{
        while(y <= x){
            z= y++;
            Console.WriteLine(z);
        }
    }
}else{
    Console.WriteLine("Números invalido.");
}
