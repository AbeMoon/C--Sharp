int n, i, p;

Console.Clear();
Console.Write("Hasta donde imprimo?: ");
n = int.Parse(Console.ReadLine());
Console..Write("A que paso?: ");
p= int.Parse(Console.ReadLine());

for( i = 0; i <= n ; i+=p)
    Console.Write($"{i} ");