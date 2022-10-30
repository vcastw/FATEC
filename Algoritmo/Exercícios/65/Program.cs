Console.WriteLine("Quantas polegadas deseja converter?");
int polegadas = int.Parse(Console.ReadLine());
double conversao = 0;
switch (polegadas){
    case 1:
    conversao = ((1*25.4) / 10);
    break;
    case 2:
    conversao = ((2*25.4) / 10);
    break;
    case 3:
    conversao = ((3*25.4) / 10);
    break;
    case 4:
    conversao = ((4*25.4) / 10);
    break;
    case 5:
    conversao = ((5*25.4)/ 10);
    break;
    case 6:
    conversao = ((6*25.4) / 10);
    break;
    case 7:
    conversao = ((7*25.4) / 10);
    break;
    case 8:
    conversao = ((8*25.4) / 10);
    break;
    case 9:
    conversao = ((8*25.4) / 10);
    break;
    case 10:
    conversao = ((8*25.4) / 10);
    break;
    case 11:
    conversao = ((11*25.4) / 10);
    break;
    case 12:
    conversao = ((12*25.4) / 10);
    break;
    case 13:
    conversao = ((13*25.4) / 10);
    break;
    case 14:
    conversao = ((14*25.4) / 10);
    break;
    case 15:
    conversao = ((15*25.4)/ 10);
    break;
    case 16:
    conversao = ((16*25.4) / 10);
    break;
    case 17:
    conversao = ((17*25.4) / 10);
    break;
    case 18:
    conversao = ((18*25.4) / 10);
    break;
    case 19:
    conversao = ((19*25.4) / 10);
    break;
    case 20:
    conversao = ((20*25.4) / 10);
    break;
    default:
    Console.WriteLine("Valor invalido tente entre 1 e 20");
    break;
}
Console.WriteLine(conversao.ToString("N2"));