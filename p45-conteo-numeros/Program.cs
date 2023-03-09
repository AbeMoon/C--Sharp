int sum = 0,n = 0, c = 0, neg = 0, pos = 0, cero = 0;

Console.Clear();

do{
   Console.Write($"Deme un numero:");
    c = int.Parse(Console.ReadLine());

    if(c != 999){
    sum += c;
    n++;
    if(c < 0) neg++;
    else if( c > 0) pos ++;
    else cero++;
    }
}while(c != 999);

 Console.WriteLine($"\n\nIntrodujiste {n} numeros");
 Console.WriteLine($"\nIntrodujiste {cero} el numero cero");
 Console.WriteLine($"\nIntrodujiste {neg} numeros negativos");
 Console.WriteLine($"\nIntrodujiste {pos} numeros positivos");
 Console.WriteLine($"\nLa suma de los valores fue: {sum}");
