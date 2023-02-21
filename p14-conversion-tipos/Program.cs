int var1 = 9;
double var2 = var1;

float var3 = 123456.789f;
double var4 = var3;

Console.Clear();
Console.WriteLine($"Implicita de int a double: {var1} -- {var2}");
Console.WriteLine($"implicita de float a double {var3} -- {var4}");

//Explicitas

double var5 = 123232.3433;
decimal var6 = 23243532423123124.234124231m;

//var5 = Convert.ToDouble(var6);

Console.WriteLine($"Manual de double a int     : {var5} -- {(int) var5} ");
Console.WriteLine($"Manual de double a int     : {var5} -- {Convert.ToInt32(var5)} ");
Console.WriteLine($"Manual de double a int     : {var5} -- {Convert.ToSingle(var5)} ");