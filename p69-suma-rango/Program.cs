float sumarango(float i, float f){
    float s = 0;
    for(float j = i; j <= f; j++)
    s += j;
    return s;
}

float res, fin, ini = 0;
Console.Clear();


res = 0;
do{
    Console.Write("Inicio: "); ini = float.Parse(Console.ReadLine());
    Console.Write("Inicio: "); fin = float.Parse(Console.ReadLine());

} while( ini > fin);

res = sumarango(ini,fin);

Console.WriteLine($"\nLa suma del rango es: {res:f2}");