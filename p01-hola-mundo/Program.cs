// Envia saludo a la pantalla

String amigo = "Juan";
string hermano = "Pablo";

Console.WriteLine(amigo);

amigo = "Miguel";

Console.WriteLine(amigo);

Console.WriteLine($"Hola {amigo} bienvenido a C#, tu no {hermano}/n");

Console.WriteLine($"{amigo.ToUpper()} {hermano.ToUpper()}");