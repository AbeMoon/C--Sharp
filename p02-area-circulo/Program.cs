// See https://aka.ms/new-console-template for more information

double radio, area;


Console.WriteLine("Calculando area de un circulo: \n");
Console.Write("Deme el radio:");
radio = double.Parse(s: Console.ReadLine());

area = Math.PI * Math.Pow(radio,2);

Console.WriteLine($"El area del circulo es: {area}");