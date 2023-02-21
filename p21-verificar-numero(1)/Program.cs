int n;

Console.Clear();
Console.WriteLine("Verifica si un numero es positivo, negativo o cero\n");
Console.Write("Deme un numero: ");
n = int.Parse(Console.ReadLine());

if (n>0) Console.WriteLine("\nEl numero es positivo...");

if (n<0) Console.WriteLine("\nEl numero es negativo...");

if (n==0) Console.WriteLine("\nEl numero es cero...");