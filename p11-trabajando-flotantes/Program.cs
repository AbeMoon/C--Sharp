// Trabajando con flotantes

float num1 = 423.45f;
float num2 = 123f;
float num3 = 1.94e-8f;

double num4 = 12332312321.434343d;
double num5 = .3456;

decimal val1 = .10m;
decimal val2 = 56565.77e23m;

Console.Clear();

Console.WriteLine($"num1 y num2 en formato normal: {num1}  y  {num2}");
Console.WriteLine($"num3 en formato exponencial: {num3:e}");
Console.WriteLine($"num4 y num5 en formato normal: {num4:f2}  y  {num2:f2}");
Console.WriteLine($"val1 en formato exponencial: {val1:p2}");
Console.WriteLine($"val2 en formato numerico: {val2:n2}");
Console.WriteLine($"val1 en formato numerico: {val1:c}");

Console.WriteLine($"\nfloat :  {float.MinValue},  {float.MaxValue}, {sizeof(float)}");
Console.WriteLine($"double :  {double.MinValue},  {double.MaxValue}, {sizeof(double)}");
Console.WriteLine($"decimal :  {decimal.MinValue},  {decimal.MaxValue}, {sizeof(decimal)}");