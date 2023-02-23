//Verificar si se acepta un alumno

string nombre;
int c1, c2, edad;

Console.Clear();
Console.Write("Bienvenido a la universidad patito, digame cual es su nombre: ");
nombre = Console.ReadLine();

Console.Write("Deme su edad: ");
edad = int.Parse(Console.ReadLine());

Console.Write("Deme su primera calificacion: ");
c1 = int.Parse(Console.ReadLine());
Console.Write("Deme su segunda calificacion: ");
c2 = int.Parse(Console.ReadLine());

if(c1 >= 8 && c2 >= 8 && edad >= 18){
    Console.WriteLine("\nFelicidades usted a sido aceptado :)");
}else if( edad < 18) Console.WriteLine("Usted no puede ser admitido, no es mayor de edad");
else{
    Console.WriteLine("\nUsted no fue admitido, reprobo una matería");
}