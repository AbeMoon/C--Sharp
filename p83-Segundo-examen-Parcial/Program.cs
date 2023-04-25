float[] cali = {0,0,0,0,0,0,0,0,0,0,0};
int i, lim, el, cont, bus, opc = 0;
bus = 0;
lim = 0;
cont = 0;
el = 0;
float prom = 0;

Console.Clear();

Console.Write("¿Cuantas calificaciones desea capturar?: ");
opc = int.Parse(Console.ReadLine());

for(i = 0; i < opc; i++){
    Console.Write($"Calificacion {i + 1}: ");
    cali[i] = float.Parse(Console.ReadLine());
    do{
        if(cali[i] < 10 || cali[i] > 100){
        Console.WriteLine("Error el valor es incorrecto, ingrese un numero mayor de 10 y menor a 100: ");
        cali[i] = float.Parse(Console.ReadLine());
        }
    }while(cali[i] < 10 || cali[i] > 100);
}

do{
    menu();
    el = int.Parse(Console.ReadLine());
    switch(el){
        case 1 : mostrar(opc); break;
        case 2 : prom = prome(opc); Console.WriteLine($"\n\nEl promedio de calificacion es:\n{prom}"); break;
        case 3 : Console.Write("\nLas Calificaciones mayores al promedio son: \n"); apro(); break;
        case 4 : Console.Write("\n\nComplementos a 100 son: \n"); comple(); break;
        case 5 : cont = busc(lim); Console.Write($"El {lim} aparece: {cont} veces"); Console.Write("\n\n");  break;
        case 6 : Console.Clear(); break;
        case 7 : Console.WriteLine("Graciaaas vuelva prontoooo"); break;
    }  
}while(el != 7);

// funciones ////////////////////////////////////////////////

void menu(){
    Console.Write("Menu:\n   1.- Mostrar arreglo\n   2.- Promedio\n   3.- Aprovatorias\n   4.- Complemento a 100\n   5.- Contar calificacion\n   6.- Limpiar Pantalla\n   7.- Salir\n\nOpcion: ");
}

void mostrar(int x){
    Console.Clear();
    Console.WriteLine("Los elementos del arreglo son: ");
    for(i = 0; i < opc; i++)
        Console.Write($"{cali[i]} ");
    Console.Write("\n\n");
}

float prome(int z){
    float y = 0;

    for(i = 0; i < z; i++)
        y += cali[i];

    return (y / z);
}
void apro(){
    for(i = 0; i < opc;i++){
    if(cali[i] >= 75)
    Console.Write($"{cali[i]} ");
    }
    Console.Write("\n\n");
}

void comple(){
    for(i = 0; i < opc;i++)
        Console.Write($"{100 - cali[i]} ");
}

int busc(int v){
    Console.Write("\n\nContar calificacion:\n"); 
    Console.Write("¿Cual cali?: "); 
    lim = int.Parse(Console.ReadLine());
    for(i = 0; i < opc;i++){
        if(cali[i] == lim)
            v++;
    }
    return v;
}