public class Alumno{
    public string Nombre {get; set;}
    public int Edad {get; set;}
    public DateTime FechaIng {get;set;}
    public bool Becado {get; set;}
    public List <int> Califs {get; set;}

    public Alumno () {}

    public Alumno (string nombre, int edad, DateTime fechaing, bool becado, List <int> califs) => (Nombre, Edad, FechaIng, Becado, Califs) = (nombre, edad, fechaing, becado, califs);

    public double Promedio() {
        int s = 0;
        foreach(int c in Califs) s+= c;
        return s/Califs.Count;
    }

    public override string ToString() =>
    ($"Nombre: {Nombre, -12}, Edad: {Edad}, FechaIng: {FechaIng}, Becado {(Becado ?"Si":"No")} ") +
    ($"Califs: {string.Join(",",Califs)}, Antiguedad: {DateTime.Now.Year - FechaIng.Year}, Prom: {Promedio()}, Mensaje: ");

}