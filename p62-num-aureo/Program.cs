
int i, j,num;

decimal f, r;

r = 0;

Console.Clear();
Console.Write($"Cual limite numerico quiere?: ");
num = int.Parse(Console.ReadLine());

for(i = 1; i <= num; i++){
    f = 1;
    for(j = 1; j <= i; j++)
    f *= j;
    r += 1/ f;
    Console.WriteLine($"Resultado = {r}");
}