public class Profesor{
    public string Nombre {get; set;}
    public DateTime FechaIng {get; set;}
    public string Grupo {get; set;}
    public string Materia {get; set;}
    public double Salario {get; set;}
    public List<Alumno> Alumnos {get; private set;}

    public Profesor() => Alumnos = new List<Alumno>();

    public Profesor (string nombre, DateTime fechaing, string grupo, string materia, double salario) =>
    (Nombre, FechaIng, Grupo, Materia, Salario) = (nombre, fechaing, grupo, materia, salario);

    public void AgregarAlumno(Alumno alumno) => Alumnos.Add(alumno);

    public override string ToString() => $"Nombre: {Nombre}, FechaIng:{FechaIng.ToString("dd/MM/yyyy")}, Grupo: {Grupo}, Materia: {Materia}, Salario: {Salario:n}";
}