public class Empleado {
    public string Nombre{get; set;}
    public int Edad {get; set;}


    //Constructor

    public Empleado(){}

    //otro ejemplo de constructor
    // public Empleado (string nobre, int edad) => (Nombre, Edad) = (Nnombre, edad);

    public void ImprimirDatos(){
        Console.WriteLine("\n");
        Console.WriteLine($"Nombre: {Nombre}");
        Console.WriteLine($"Edad:   {Edad}");
    }
}

