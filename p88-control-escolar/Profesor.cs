public class Profesor{
    public string Nombre {get; set;}
    public DateTime FechaIng {get; set;}
    public string Grupo {get; set;}
    public String Materia {get; set;}
    public double Salario {get; set;}
    public List <Alumno> Alumnos {get; private set;}

    public Profesor() => Alumnos = new List<Alumno>();
    public Profesor(string nombre,DateTime fechaing, string grupo, string materia, double salario) : this() =>
            (Nombre, FechaIng, Grupo, Materia, Salario) = (nombre, fechaing, grupo, materia, salario);
    
    public void AgregarAlumno(Alumno alumno) => Alumnos.Add(alumno);

    public double PromedioClase() {
        double s = 0;
        foreach(Alumno al in Alumnos)
        s += al.Promedio();
        return s / Alumnos.Count;
    }

    public int TotalBecados(){
        int  c = 0;
        foreach (Alumno a in Alumnos)
        c+= (a.Becado?1:0);
        return c;
    }
    public override string ToString() =>
    $"Nombre : {Nombre,-12}, FechaIng: {FechaIng}";
}