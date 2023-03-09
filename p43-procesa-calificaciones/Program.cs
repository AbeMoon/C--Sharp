int n = 0, c = 1;
float p = 0, ca = 0;

Console.Clear();

Console.Write("Cuantas calificaciones quiere meter?: ");
n = int.Parse(Console.ReadLine());

Console.Write("\n");

while ( c <= n){
   Console.Write($"Deme la falificacion #{c}: ");
    ca += float.Parse(Console.ReadLine());
    c++;
}
 p = ca / n;

 Console.WriteLine($"\nSu calificacion es de: {p}");