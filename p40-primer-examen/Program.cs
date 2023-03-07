
int tipo = 0, paq = 0,canti = 0, cob = 0;
float sub = 0f, total= 0f, desc = 0f;

string tipoC = "", pq = "";

tipo = int.Parse(args[0]);
paq = int.Parse(args[1]);
canti = int.Parse(args[2]);

switch(tipo){
    case 1: desc = 0.2f; cob = 100; tipoC = "Alumnos"; break;
    case 2: desc = 0.1f; cob = 200; tipoC = "Trabajadores"; break;
    case 3: desc = 0.05f; cob = 500; tipoC = "Docentes"; break;
    default: Console.Write("Ingrese valores validos para poder procesar el pedido"); break;
}

switch(paq){
    case 1: paq = 600; pq = "Conferencia";break;
    case 2: paq = 800; pq  = "Evento"; break;
    case 3: paq = 900; pq = "Kit"; break;
    default: Console.Write("Ingrese valores validos para poder procesar el pedido"); break;
}

sub = (cob + paq) * canti;
total = sub - (sub * desc);

Console.Clear();
Console.WriteLine("Bienvenidos a la universidad Cualpan-------------\n");
Console.WriteLine($"Pediste:                {canti} de espacios");
Console.WriteLine($"De los cuales son para: {tipoC}");
Console.WriteLine($"Para el/la              {pq}");
Console.WriteLine($"Su descuento sera de:   {desc * 100} %");
Console.WriteLine($"con un Subtotal de:     {sub:c}");
Console.WriteLine($"y un Total de:          {total:c}");