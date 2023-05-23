public class Escuela{
    public string Nombre {get; set;}
    public string Responsable{get; set;}
    public string Domicilio {get; set;}
    public List<Profesor> Profesores {get; private set;}

    public Escuela() => Profesor = new List<Profesor>();

    public Escuela(string nombre, string responsable, string domicilio) : this() => (Nombre, Responsable, Domicilio) = (nombre, responsable, domicilio);

    public void AgrerProfesor(Profesor profesor) => Profesores.Add(profesor);

    public override string ToString() => $"Nombre {Nombre}, Responsable: {Responsable}, Domicilio: {Domicilio}";
}