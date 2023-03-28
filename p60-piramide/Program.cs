
int i, j,num;

Console.Clear();
Console.Write($"Cuantos renglones quiere?: ");
num = int.Parse(Console.ReadLine());

for(i = 1; i <= num; i++){
    for(j = 1; j <= i; j++){
        Console.Write("*");
    }
    Console.Write("\n");
}