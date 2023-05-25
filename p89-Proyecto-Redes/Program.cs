// Inicializar datos previos

Red red = new Red ("Red Patito, S.A. de C.V", "Mr Pato Macdonald", "Av. Princeton 123, Orlando, Florida");


//agregar nodos

red.AgregarNodo(new Nodo("192.168.0.10", "servidor", 5, 10, "linux"));
red.AgregarNodo(new Nodo("192.168.0.12", "equipoactivo", 2, 12, "ios"));
red.AgregarNodo(new Nodo ("192.168.0.20", "computadora", 8, 5, "windows"));
red.AgregarNodo(new Nodo ("192.168.0.15", "servidor", 10, 22, "linux"));

//agregar vulnerabilidades

red.Nodos[0].AgregarVulne(new Vulnerabilidad("CVE-2015-1635","microsoft",
"HTTP.sys permite a atacantes remotos ejecutar código arbitrario", "remota", DateTime.Parse("14/04/2015")));

red.Nodos[0].AgregarVulne(new Vulnerabilidad("CVE-2017-0004", "microsoft",
"El servicio LSASS permite causar una denegación de servicio", "local" , DateTime.Parse("10/01/2011")));

red.Nodos[1].AgregarVulne(new Vulnerabilidad ("CVE-2017-3847", "cisco", 
"Cisco Firepower Management Center XSS", "remota", DateTime.Parse("21/02/2017")));

red.Nodos[2].AgregarVulne(new Vulnerabilidad("CVE-2009-2504", "microsoft", 
"Múltiples desbordamientos de enteros en APIs Microsoft .NET 1.1", "local", DateTime.Parse("13/11/2009")));

red.Nodos[2].AgregarVulne(new Vulnerabilidad ("CVE-2016-7271", "microsoft", 
"Elevación de privilegios Kernel Segura en Windows 10 Gold", "local", DateTime.Parse("20/12/2016")));

red.Nodos[2].AgregarVulne(new Vulnerabilidad("CVE-2017-2996", "adobe", 
"Adobe Flash Player 24.0.0.194 corrupción de memoria explotable", "remota", DateTime.Parse("15/02/2017")));

int a, op = 0;

a = 1;

Console.Clear();

do{
  Console.Clear();
  Console.Write("A continuación se les dara un menu de opciones, elija la que desee:\n    1.- Mostrar datos" 
                + "\n    2.- Agregar nuevo Nodo\n    3.- Agregar Vulnerabilidad\n    4.- Salir\n\nOpcion: ");
  op = int.Parse(Console.ReadLine());
  switch(op){
    case 1 : impresion(); break;
    case 2 : AgregarNod(); break;
    case 3 : AgregarVulnera(); break;
    case 4 : a = salir(); break;
    default: a = salir(); break;
  }
} while(a == 1);

void impresion(){
  int totalNod = 0;

  int totalVul = 0;

  int maynusa = 0;
  int menusa = 0;

  DateTime antigue = DateTime.Today;

  Console.Clear();
  Console.WriteLine("\n\n\n>> Datos generales de la red:\n");
  Console.WriteLine($"{red.ToString()}");

  totalNod = red.Nodos.Count;

  foreach(Nodo n in red.Nodos){
    totalVul += n.Vulnerabilidades.Count();
  }

  Console.WriteLine($"\nTotal nodos red   : {totalNod}\nTotal vulnerabilidades : {totalVul}\n\n");

  int vulN = 0;

  int  i = 0;

  foreach(Nodo n in red.Nodos){
    Console.Write($"{n.ToString()}, TotVul: {vulN = red.Nodos[i].Vulnerabilidades.Count} \n"); 
    i++;
  }

    maynusa = red.Nodos[0].Saltos;
    menusa = red.Nodos[0].Saltos;

   for(i = 1; i < red.Nodos.Count; i++){

    if(maynusa < red.Nodos[i].Saltos){
      maynusa = red.Nodos[i].Saltos;}
    if(red.Nodos[i].Saltos < menusa){
      menusa = red.Nodos[i].Saltos; }
  }

  Console.Write($"\nMayor numero de saltos: {maynusa}\nMenor numero de saltos: {menusa}\n");

  Console.WriteLine("\n\n>>Vulnerabilidades por nodo:\n");

  for(i = 0; i < totalNod; i++){
    Console.Write($"> IP: {red.Nodos[i].IP},  Tipo: {red.Nodos[i].Tipo}\n");
    vulN = red.Nodos[i].Vulnerabilidades.Count;
    if(vulN == 0){Console.Write("\n   No tiene Vulnerabilidades");}
    for(int j = 0; j < vulN; j++){
        if(red.Nodos[i].Vulnerabilidades.Count != 0){
          var anios = ((DateTime.Now - red.Nodos[i].Vulnerabilidades[j].Fecha).TotalDays)/365;
          Console.Write($"\n   {red.Nodos[i].Vulnerabilidades[j].ToString()},  Antiguerdad: {anios.ToString("#.##")} años");
        }
    }
    vulN = 0;
    Console.Write("\n\n");
  }

  Console.Write("\n\n\n***Teclee algun numero para continuar:   ");
  int c = 0;
  c = int.Parse(Console.ReadLine());

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

    Console.Write("\nQué sistema operativo usa? (linux, windos, ios): ");
    so = Console.ReadLine();

    red.AgregarNodo(new Nodo(ip,tipo,puertos,saltos,so));

}

void AgregarVulnera(){
    string clave, vendedor, descripcion, tipov;
    DateTime fecha;
    int nodopc = 0;
    int notop = 0;
    int d = 0;

    notop = red.Nodos.Count;

    do{
      Console.Clear();
      Console.Write($"Tenemos nodos del 1 al {notop}\nPara que nodo quiere la vulnerabilidad?: ");
      nodopc = int.Parse(Console.ReadLine());

      if(nodopc <= notop && nodopc >= 1){
        Console.Write("\nQue clave tiene la vulnerabilidad?: ");
        clave = Console.ReadLine();

        Console.Write("\nQuien es el vendedor?: ");
        vendedor = Console.ReadLine();

        Console.Write("\nLa vulnerabilidad tiene descripcion?: ");
        descripcion = Console.ReadLine();

        Console.Write("\nQué tipo de vulnerabilidad es?(Local/Remota/equipoactivo): ");
        tipov = Console.ReadLine();

        Console.Write("\nCual es la fecha de la vulnerabilidad?(dd/mm/yyyy): ");
        fecha = DateTime.Parse(Console.ReadLine());

        red.Nodos[nodopc - 1].AgregarVulne(new Vulnerabilidad(clave, vendedor, descripcion, tipov, fecha));
        d = 1;
      }else{Console.WriteLine("\n\nError, numero invalido de nodo");}
    }while(d == 0);
}

int salir(){
  int z = 0;

  Console.Clear();

  Console.WriteLine("Programa finalizado, por su atencion muchas gracias :)\n\n\nPrograma realizado por César Luna");

  return z;
}