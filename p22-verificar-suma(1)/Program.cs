//Verifica si la suma de 2 numero da el tercero

int n,m,o;

Console.Clear();

Console.WriteLine("Deme 1 numero");
n = int.Parse(Console.ReadLine());

Console.WriteLine("Deme otro numero");
m = int.Parse(Console.ReadLine());

Console.WriteLine("Deme el ultimo numero");
o = int.Parse(Console.ReadLine());

if((n+m) == o) Console.WriteLine("Ambos numeros sumados dan el tercero");

else Console.WriteLine("La suma de los numeros no da el tercero");