char op;
float temp,res;

Console.Clear();
Console.WriteLine("Convertir temperatura de grados celcius a farnheit y viceversa: \n");
Console.WriteLine("[F]arnheit   ");
Console.WriteLine("[C]entigrados");
Console.Write("Eliga una opcion: ");
op = char.ToUpper(Console.ReadLine()[0]);

Console.WriteLine("\nDeme una temperatura: ");
temp = float.Parse(Console.ReadLine());

if(op == 'F'){  Console.WriteLine("Convirtiendo a Farnheit");
    res = (temp * 9/5) + 5/9;

}else{ Console.WriteLine("Convirtiendo a Celcius");
    res = (temp-32) * 5/9;
}

Console.WriteLine($"\nTemperatura es igual a = {res}° {op}");