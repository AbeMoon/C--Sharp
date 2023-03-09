int n = 0, c = 1, r = 1, t = 1;

Console.Clear();

Console.Write("Cuantas tabla quiere ver?: ");
n = int.Parse(Console.ReadLine());

Console.Write("Hasta que valor?: ");
t = int.Parse(Console.ReadLine());

Console.Write("\n");

while ( c <= t){
    r = n * c;
   Console.Write($"\n{n} x {c} = {r}");
    c++;
}

 Console.WriteLine($"\n\nPrograma terminado :)");