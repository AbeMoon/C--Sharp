// ayuda a calcular si un trabajador trabaja extra y cuanto pagar le
string nombre;
int horas;
float extra, paga, total;

Console.Clear();
Console.Write("Deme su nombre: "); 
nombre = Console.ReadLine();

Console.Write("\n¿Cuantas horas trabajo en la semana?: ");
horas = int.Parse(Console.ReadLine());

Console.Write("\nCuanto te pagan por hora?: ");
paga = float.Parse(Console.ReadLine());

if (horas> 40){
    extra = ((horas - 40) * (paga * 2));
    Console.WriteLine($"Su salario es de: ${total = 40 * paga} pesos");
    Console.WriteLine($"Dado que usted trabajo {horas - 40} horas extra, se le bonifica con {extra} pesos");
    Console.WriteLine($"\n Salario total : $ {extra + (total = 40 * paga) } pesos");
}else{
    total = horas * paga;

    Console.WriteLine($"Su salario es de: ${total} pesos");
}