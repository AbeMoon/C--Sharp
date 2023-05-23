public class Vulnerabilidad{
    public string Clave {get; set;}
    public string Vendedor{get; set;}
    public string Descripcion {get; set;}
    public string Tipo {get; set;}
    public DateTime Fecha {get; set;}

    public Vulnerabilidad () {}

    public Vulnerabilidad(string clave, string vendedor, string descripcion, string tipo, DateTime fecha) =>
    (Clave, Vendedor, Descripcion, Tipo, Fecha) = (clave, vendedor, descripcion, tipo, fecha);

}