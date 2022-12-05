Console.WriteLine("Digite dois número em ordem crescente: ");
int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());
int z;
int s;
s = 0;
while(x<y){
    z=x++;
    if(z % 2 == 0){
        s= s+ z;
    }
}
Console.WriteLine(s);