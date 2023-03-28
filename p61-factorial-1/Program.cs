
int i, j,num,f;

f = 0;

Console.Clear();
Console.Write($"Cual numero en factorial quiere?: ");
num = int.Parse(Console.ReadLine());

for(i = 1; i <= num; i++){
    f = 1;
    for(j = i; j<= num; j++){
        f*= i;
        Console.Write($"Factorial = {f}   ");
    }
    Console.Write("\n");
}