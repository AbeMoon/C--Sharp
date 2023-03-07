// See https://aka.ms/new-console-template for more information

int num1 = 42;
int num2 = 0x2A;
int num3 = 0b00101010;

sbyte edad = 95;
ulong aniosluz = 12312312312344444441;

Console.Clear();

Console.Write($"Decimal {num1} {num2} {num3}");
Console.Write($"num1 en base 10 {num1}");
Console.Write($"num1 en base 8 {Convert.ToString(num1,8)}");
Console.Write($"num1 en base 16 {Convert.ToString(num1,16)}");
Console.Write($"num1 en base 2 {Convert.ToString(num1,2)}");

Console.WriteLine($"sbyte : {sbyte.MaxValue},   {Sbyte.MaxValue}");
Console.WriteLine($"byte : {byte.MinValue},   {byte.MaxValue}");
Console.WriteLine($"int : {int.MaxValue},   {int.MaxValue}");
Console.WriteLine($"short : {short.MaxValue},   {short.MaxValue}");
Console.WriteLine($"long : {long.MaxValue},   {long.MaxValue}");
Console.WriteLine($"ulong : {ulong.MaxValue},   {ulong.MaxValue}");