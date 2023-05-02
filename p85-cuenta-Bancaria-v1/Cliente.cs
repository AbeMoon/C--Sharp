public class Cliente{
    public String Nombre {get; set;}
    public String Apellido {get; set;}

    public CuentaBancaria cuenta {get; set;}

    public Cliente (string nombre, string apellido) => (Nombre,Apellido) = (nombre,apellido);

    public override string ToString() => $"{Nombre} , {Apellido}";
}