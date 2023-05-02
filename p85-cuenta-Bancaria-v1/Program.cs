Console.WriteLine("Probando clase");

CuentaBancaria cuenta1 = new CuentaBancaria(5000);

cuenta1.Deposita(100000);

Console.WriteLine($"El saldo de la cuenta es: {cuenta1.Saldo}");

bool retiro = cuenta1.Retira(56);

if(retiro)
    Console.WriteLine($"Saldo actual es: {cuenta1.Saldo}");
else 
    Console.WriteLine("Ni para eso tienes");

/*
Cliente.cliente1 = new Cliente("David","Monreal");
cliente1.Cuenta = cuenta1;

Console.WriteLine($"Cliente  :   {cliente.toString()}");
Console.WriteLine($"El saldo es: {cliente1.Cuenta.Saldo}");

Cliente cliente2 = new Cliente("Carlos","Carranza");
cliente2.cuenta = new CuentaBancaria(100000000);

cliente2.Cuenta.Retira(500000);

Console.WriteLine($"El saldo de {cliente2.Nombre} ahora es: {cliente2.Saldo}");
*/

Console.WriteLine("Probando Banco");
Banco mibanco = new Banco ("Banco Olmenza", "tu casa");

//mibanco.AgregarCliente(cliente1);
//mibanco.AgregarCliente(cliente2);

Cliente cliente3 = new Cliente ("Solo Vino", "Solo se fue");
cliente3.cuenta = new CuentaBancaria(100001);

mibanco.AgregarCliente(cliente3);

mibanco.Clientes[0].cuenta.Deposita(10000);

Console.WriteLine($"Banco :  {mibanco.ToString()}");
foreach(Cliente cl in mibanco.Clientes){
    Console.WriteLine($"Cliente: {cl.ToString()}");
    Console.WriteLine($"Saldo  : {cl.cuenta.Saldo}");
}

