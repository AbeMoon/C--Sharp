// validador de estaciones

int opc;

Console.Clear();
Console.Write("Bienvenido, para iniciar deme un numero del 1 al 4: ");
opc = int.Parse(Console.ReadLine());

if(opc >= 1 && opc <= 4){
    if(opc == 1)
        Console.WriteLine("Su estacion es Primavera");
    if(opc == 2)
        Console.WriteLine("Su estacion es Verano");
    if(opc == 3)
        Console.WriteLine("Su estacion es Otoño");
    if(opc == 4)
        Console.WriteLine("Su estacion es Invierno");
}else
    Console.WriteLine("Le pedi un numero entre 1 y 4 animal");