int n, i;
float sum =0, prom = 0;

Console.Clear();

Console.Write("Cuantas materias tuviste?: ");
n = int.Parse(Console.ReadLine());

for(i = 1; i <= n; i++){
    Console.Write($"Deme su cali #{i}: ");
    sum += float.Parse(Console.ReadLine());
}
 prom = sum / n;

 Console.WriteLine($"Tu promedio es de: {prom}");