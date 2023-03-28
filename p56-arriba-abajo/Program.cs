int op, n;

Console.Clear();
Console.WriteLine("[1] números de 1 a n");
Console.WriteLine("[2] números de n a 1");
Console.WriteLine("Elige ?"); op = int.Parse(Console.ReadLine());

switch(op){
    case 1 : Console.WriteLine("Imprimiendo los numeros de 1 a {n}"); 
    Console.Write("Hasta donde?: "); n = int.Parse(Console.ReadLine());
    for(i = 1; i <= n; i++)
        Console.Wrie($"{i} ");
    break;
    case 2 : Console.WriteLine("Imprimiendo los numeros de {n} a 1"); 
    Console.Write("Hasta donde?: "); n = int.Parse(Console.ReadLine());
    for(i = n; i >= 1; i--)
        Console.Wrie($"{i} ");
    break;
}