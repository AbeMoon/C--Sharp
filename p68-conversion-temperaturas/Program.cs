float fatenheit(float t){
    return (t*9/5) + 32;
}

float celcius(float t){
    return (t-32) * 5/9;
}


int op;
float temp,resu = 0;

Console.Clear();
Console.WriteLine("Conversion de temperatura usada funciones \n");
Console.WriteLine("[1] Farenheit\n[2] Centigrados");
Console.Write("Opcion?: "); op = int.Parse(Console.ReadLine());

switch(op){
    case 1:
    Console.WriteLine("Deme la temperatura en Centigrados: "); 
    temp = float.Parse(Console.ReadLine());
    resu = fatenheit(temp);
    break;
    case 2:
    Console.WriteLine("Deme la temperatura en Farenheit: "); 
    temp = float.Parse(Console.ReadLine());
    resu = celcius(temp);
    break;
    default:
    Console.WriteLine("Opcion invalida"); 
    break;
}

Console.WriteLine($"La temperatura es de: {resu}°");
