public class Alumno{
    public string Nombre {get; set;}
    public int Edad {get; set;}
    public DateTime FechaIng {get;set;}
    public bool Beca {get; set;}
    public List <int> Califs {get; set;}

    public Alumno (string nombre, int edad, DateTime fechaing, bool beca, List <int> califs) =>
    (Nombre, Edad, FechaIng, Beca, Califs) = (Nombre, Edad, fechaing, Beca, califs);

    public override string ToString() => $"Nombre: {Nombre}, Edad:{Edad}, FechaIng:{FechaIng.ToString("dd/MM/yyyy")}, Beca: {(Beca?"Si":"No")}, Califs: {string.Join(", ", Califs)}";
}