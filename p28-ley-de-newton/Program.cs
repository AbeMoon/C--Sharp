//Validador de la segunda ley de newton

float f,m,a;

Console.Clear();
Console.Write("Bienvenido, en el siguiente menu calcula la ley de newton\n\n\n1.- Fuerza = masa * aceleracion.\n2.-Masa = Fuerza / aceleracion\n3.- Aceleracion = Fuerza / masa\n\nOpcion: ");
int opc = int.Parse(Console.ReadLine());
//[0] para que solo agarre el primer caracter

if(opc == 1){
    Console.Write("\nDeme la Masa; ");
    m = float.Parse(Console.ReadLine());
    Console.Write("\nDeme la aceleracion; ");
    a = float.Parse(Console.ReadLine());
    f = m * a;

    Console.WriteLine($"\nLa fuerza es igual a: {f}");

}else if(opc == 2){
    Console.Write("\nDeme la fuerza; ");
    f = float.Parse(Console.ReadLine());
    Console.Write("\nDeme la aceleracion; ");
    a = float.Parse(Console.ReadLine());
    m = f / a;

    Console.WriteLine($"\nLa masa es igual a: {m}");

}else if(opc == 2){
    Console.Write("\nDeme la fuerza; ");
    f = float.Parse(Console.ReadLine());
    Console.Write("\nDeme la Masa; ");
    m = float.Parse(Console.ReadLine());
    a = f / m;

    Console.WriteLine($"\nLa aceleracion es igual a: {a}");

}else{
    Console.WriteLine("Eliga una opcion valida");
}