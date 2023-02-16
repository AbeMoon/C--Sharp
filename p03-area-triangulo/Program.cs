
// See https://aka.ms/new-console-template for more information

double baset, altura;
float area;

Console.WriteLine("Calculando area de un triangulo: \n");
Console.Write("Deme la base:");
baset = double.Parse(Console.ReadLine());

Console.Write("Deme la altura:");
altura = double.Parse(Console.ReadLine());

area = (float)((baset*altura)/2);

Console.WriteLine($"El area del triangulo es: {area}");

