int i = 0;
double cvt = 0;
for(i = 1; i <= 20; i++){
    cvt = (i * 25.4) / 10;
    Console.WriteLine($"Conversão de {i} polegada em centimetros: {cvt.ToString("N2")}");
} 