int c = 1, n = 0;

Console.Clear();

Console.Write("¿Hasta que numero quieres llegar?: ");
n= int.Parse(Console.ReadLine());

while(c < n){
    Console.WriteLine($"{c}");
    c++;
}

Console.WriteLine("Proceso terminado ... :)");