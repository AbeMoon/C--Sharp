//Verificador de angulos

int opc;

Console.Clear();
Console.Write("Deme un angulo entre 0 y 360: ");
opc = int.Parse(Console.ReadLine());

Console.Write("\n");

if(opc > 0 && opc < 361){
    if(opc < 90) Console.WriteLine("Su angulo es agudo :) ");
    if(opc == 90) Console.WriteLine("Su angulo es Recto");
    if(opc > 90 && opc < 180) Console.WriteLine("Su angulo es Obtuso");
    if(opc == 180) Console.WriteLine("Su angulo es Llano :) ");
    if(opc > 180 && opc < 360) Console.WriteLine("Su angulo es concavo");
    if(opc == 180) Console.WriteLine("Felicidades usted tiene una circunferencia");
}else if(opc <= 0) Console.WriteLine("Deme un angulo positivo animal, no se pase de graciosos jaja");
else Console.WriteLine("Su angulo pasa de ser un circulo y sobre extiende lo requerido");