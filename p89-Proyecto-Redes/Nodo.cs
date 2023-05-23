public class Nodo{
    public string IP {get; set;}
    public string Tipo {get; set;}
    public int Puertos {get; set;}
    public int Saltos {get; set;}
    public string SO {get; set;}
    public List<Vulnerabilidad> Vulnerabilidades {get; private set;}

    public Nodo() => Vulnerabilidades = new List<Vulnerabilidad>();

    public Nodo(string ip, string tipo, int puertos, int saltos, string so) =>
    (IP, Tipo, Puertos, Saltos, SO) = (ip, tipo, puertos, saltos, so);

    public void AgregarVulne (Vulnerabilidad vul) => Vulnerabilidades.Add(vul);

    public override string ToString() => $"Ip: {IP}, Tipo: {Tipo},  Puertos: {Puertos}, Saltos: {Saltos}, So: {SO}";

}