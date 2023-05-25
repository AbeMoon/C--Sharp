public class Red{
    public string Empresa {get; set;}
    public string Propietario {get; private set;}
    public string Domicilio {get; set;}
    public List<Nodo> Nodos {get; private set;}

    public Red() => Nodos = new List<Nodo>();

    public Red(string empresa, string propietario, string domicilio):this() => (Empresa, Propietario, Domicilio) = (empresa, propietario, domicilio);

    public void AgregarNodo(Nodo nodo) => Nodos.Add(nodo);

    public override string ToString() => $"Empresa  :  {Empresa}\nPropietario  : {Propietario} \nDomicilio  :   {Domicilio}";
}