int horas;
string nombre;
float paga, pagabruta, salario;
float impuesto;

Console.Clear();

Console.WriteLine("Calculando su salario: \n");
Console.Write("Cual es su nombre?:");
nombre = Console.ReadLine();
Console.Write("Deme salario por día:");
paga = float.Parse(Console.ReadLine());
Console.Write("Cuantos dias trabajo?:");
horas = int.Parse(Console.ReadLine());

impuesto = 0.10f;


pagabruta = horas * paga;
salario = pagabruta - (pagabruta*impuesto);

Console.WriteLine($"{nombre} tu salario bruto es de: {pagabruta}");
Console.Write($"Pero tu salario es de: {salario}");