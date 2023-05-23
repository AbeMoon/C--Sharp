// Inicializar datos previos


Red red = new Red ("Red Patito, S.A. de C.V", "Mr Pato Macdonald", "Av. Princeton 123, Orlando, Florida");


//agregar nodos

red.AgregarNodo(new Nodo("192.168.0.10", "servidor", 5, 10, "linux"));
red.AgregarNodo(new Nodo("192.168.0.12", "equipoactivo", 2, 12, "ios"));
red.AgregarNodo(new Nodo ("192.168.0.20", "computadora", 8, 5, "windows"));
red.AgregarNodo(new Nodo ("192.168.0.15", "servidor", 10, 22, "linux"));

//agregar vulnerabilidades

red.Nodos[0].AgregarVulne(new Vulnerabilidad("CVE-2015-1635","microsoft",
"HTTP.sys permite a atacantes remotos ejecutar código arbitrario", 4/14/2015));

red.Nodos[0].AgregarVulne(new Vulnerabilidad("CVE-2017-0004", "microsoft",
"El servicio LSASS permite causar una denegación de servicio", "local" , 1/10/2011));

red.Nodos[1].AgregarVulne(new Vulnerabilidad ("CVE-2017-3847", "cisco", 
"Cisco Firepower Management Center XSS", "remota", 02/21/2017));

red.Nodos[2].AgregarVulne(new Vulnerabilidad("CVE-2009-2504", "microsoft", 
"Múltiples desbordamientos de enteros en APIs Microsoft .NET 1.1", "local", 11/13/2009));

red.Nodos[2].AgregarVulne(new Vulnerabilidad ("CVE-2016-7271", "microsoft", 
"Elevación de privilegios Kernel Segura en Windows 10 Gold", "local", 12/20/2016));

red.Nodos[2].AgregarVulne(new Vulnerabilidad("CVE-2017-2996", "adobe", 
"Adobe Flash Player 24.0.0.194 corrupción de memoria explotable", 2/15/2017));

//red.Nodos[0].AgregarVulne();

// impresión


int a, op = 0;

a = 1;

Console.Clear();

do{
  Console.Write("A continuación se les dara un menu de opciones, elija la que desee: ");
  op = int.Parse(Console.ReadLine());
  switch(op){
    case 1 : impresion(); break;
    case 2 : AgregarNod(); break;
    case 3 : AgregarVulnera(); break;
    default: Console.Clear(); Console.WriteLine("Gracias por su atención"); break;
  }
} while(a == 1);

//Console.WriteLine($"Total nodos red    : {red.Nodos.Count}");

//Console.WriteLine("\n\n>> Datos generales de los nodos:\n");
//Console.WriteLine($"{nodo.ToString()}");
//foreach(Nodo n in red.Nodos){
  //  Console.WriteLine($"n.ToString()");
//}

void impresion(){

  int totalNod = 0;

  int totalVul = 0;

  Console.Clear();
  Console.WriteLine(">> Datos generales de la red:\n");
  Console.WriteLine($"{red.ToString()}");

  totalNod = red.Nodos.Count;

  foreach(Nodo n in red.Nodos){
    totalVul += n.Vulnerabilidades.Count();
  }

  Console.WriteLine($"\nTotal nodos red   : {totalNod}\nTotal vulnerabilidades : {totalVul}");

  foreach(Nodo n in red.Nodos){
    Console.Write($"{n.ToString()}"); 
  }

  Console.WriteLine("\n\n>>Vulnerabilidades por nodo:");

  foreach(Vulnerabilidades v in red.Nodos){
    Console.Write($"{v.ToString()}");
  }

}

void AgregarNod(){
    string ip, tipo, so;
    int puertos, saltos = 0;
    puertos = 0;

    Console.Write("\nDeme la ip del nodo: ");
    ip = Console.ReadLine();

    Console.Write("\nDeme el tipo de nodo puede ser (servidor, computador, equipoactivo): ");
    tipo = Console.ReadLine();

    Console.Write("\nCuantos puertos tiene el nodo?: ");
    puertos = int.Parse(Console.ReadLine());

    Console.Write("\nCuantos saltos tiene ese nodo?: ");
    saltos = int.Parse(Console.ReadLine());

    Console.Write("\nQué sistema operativo usa? (linux, windos, ios)");
    so = Console.ReadLine();

    //red.AgregarNodo(new Nodo(ip,tipo,puertos,saltos,so));

}

void AgregarVulnera(){
    string clave, vendedor, descripcion, tipov;
    DateTime fecha;
    int nodopc;

    Console.Write("Para que nodo quire la vulnerabilidad?: ");
    nodopc = int.Parse(Console.ReadLine());

    Console.Write("\nQue clave tiene la vulnerabilidad?: ");
    clave = Console.ReadLine();

    Console.Write("\nQuien es el vendedor?: ");
    vendedor = Console.ReadLine();

    Console.Write("\nLa vulnerabilidad tiene descripcion?: ");
    descripcion = Console.ReadLine();

    Console.Write("\nQué tipo de vulnerabilidad es?: ");
    tipov = Console.ReadLine();

    Console.Write("\nCual es la fecha de la vulnerabilidad?: ");
    fecha = DateTime.Today();

    red.Nodos[nodopc].AgregarVulne(new Vulnerabilidad(clave, vendedor, descripcion, tipov, fecha));

}