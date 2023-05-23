// Inicializar


Red red = new Red ("Red Patito, S.A. de C.V", "Mr Pato Macdonald", "Av. Princeton 123, Orlando, Florida");

//red.Nodos[0] (new Nodo ()"192.168.0.10", "servidor", 5, 10, "linux");

//red.Nodos[0] (new Nodo ("192.168.0.10", "servidor", 5, 10, "linux"));

//red.Nodos[0].AgregarNodo();

//red.AgregarNodo(new Nodo("192.168.0.10", "servidor", 5, 10, "linux"));

//red.AgregarNodo(new Nodo(ip: "192.168.0.10",tipo: "servidor",puertos: 5,saltos: 10,so: "linux"));
//red.AgregarNodo(new Nodo());


//red.Nodos[0].AgregarVulne(new Vulnerabilidad ());

//red.AgregarNodo(new Nodo("192.168.0.12", "equipoactivo", 2, 12, "ios"));

//red.Nodos[0].AgregarVulne();

//Nodo nodo1 = new Nodo ("192.168.0.10", "servidor", 5, 10, "linux");
//Nodo nodo2 = new Nodo ("192.168.0.12", "equipoactivo", 2, 12, "ios");
//Nodo nodo3 = new Nodo ("192.168.0.20", "computadora", 8, 5, "windows");
//Nodo nodo4 = new Nodo ("192.168.0.15", "servidor", 10, 22, "linux");

// impresión

Console.Clear();

Console.WriteLine(">> Datos generales de la red:\n");
Console.WriteLine($"{red.ToString()}");

//Console.WriteLine($"Total nodos red    : {red.Nodos.Count}");

//Console.WriteLine("\n\n>> Datos generales de los nodos:\n");
//Console.WriteLine($"{nodo.ToString()}");
//foreach(Nodo n in red.Nodos){
  //  Console.WriteLine($"n.ToString()");
//}

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

    //Console.Write("\nCual es la fecha de la vulnerabilidad?: ");
    fecha = DateTime.Today();

    red.Nodos[nodopc].AgregarVulne(new Vulnerabilidad(clave, vendedor, descripcion, tipov, fecha));

}