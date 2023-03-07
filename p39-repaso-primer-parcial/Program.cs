// See https://aka.ms/new-console-template for more information

void Menu() {
Console.Clear();
Console.WriteLine("\nElija como deseas armar tu pedid a de pizza: \n");
Console.WriteLine("Tamaño :      [C]hica  $5 - [M]ediana $10 - [G]rande $15");
Console.WriteLine("Ingredientes: [E]xtra queso, [C]hampiñones, [P]iña, unidas por un + ~ $5 po cada ingrediente");
Console.WriteLine("Cubierta:     [D]elgada, [G]ruesa");
Console.WriteLine("Comer:        [A]qui, para [L]levar");

}

char tam, cub, don;
string[] ings;

string tamaño ="", ingredientes = "", cubierta  = "", donde = "", cliente = "";
float subtotal = 0, desc = 0, total = 0, cant = 0, subtot = 0;


if(args.Length < 1) {
    Menu();
    return 1;
}

//Procesa tamaño

tam = char.Parse(args[0].ToUpper());
if(tam == 'C'){ tamaño = "Chica"; subtotal = 5; }
else if(tam == 'M'){tamaño = "Mediana"; subtotal = 10;}
else {tamaño = "Grande"; subtotal = 15;}

//Procesa ingredientes

ings = args[1].Split("+");

foreach(string ing in ings){
    switch( char.Parse(ing.ToUpper() )) {
        case 'E' : ingredientes += "Extra queso "; break;
        case 'C' : ingredientes += "Champiñones "; break;
        case 'P' : ingredientes += "Puña "; break;
    }    
    subtotal += 5;
}

cub = char.Parse(args[2].ToUpper());
cubierta = (cub == 'D' ? "Delgada" : "Gruesa");

don = char.Parse(args[3].ToUpper());
donde = (don == 'A' ? "Aqui" : "Llevar");

///Procesar la cantidad
cant = float.Parse(args[4]);
subtot = subtotal * cant;

if(subtot < 1000) {desc = 0; cliente = "Platino";}
else if( subtot > 1000 && subtot < 2000) {desc = 0.1f; cliente = "Plata";}
else {desc = 0.2f; cliente = "Oro";}

total = subtot - (subtot * desc);


Console.Clear();

Console.WriteLine($"Tamaño:       {tamaño}");
Console.WriteLine($"Ingredientes: {ingredientes}");
Console.WriteLine($"Cubierta:     {cubierta}");
Console.WriteLine($"Lugar:        {donde}");
Console.WriteLine($"Cantidad:     {cant}");
Console.WriteLine($"Subtotal:     {subtotal:c}");
Console.WriteLine($"Eres Cliente: {donde}");
Console.WriteLine($"Descuento:    {desc:p2}");

Console.WriteLine($"\nTotal:      {total:c}");

return 0;