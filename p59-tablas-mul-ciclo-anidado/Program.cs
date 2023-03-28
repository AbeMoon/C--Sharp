
int i, j;

Console.Clear();


for(i = 1; i <= 10; i++){
    Console.Write($"Tabla del: {i}");
    for(j = 1; j <= 10; j++){
        Console.WriteLine($"{i} x {j} = {i*j}");
    }
    Console.Write("\n");
}