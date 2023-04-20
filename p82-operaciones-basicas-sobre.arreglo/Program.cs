float n1, n2, n3, n4, n5, suma, prome, bus;
bus = suma = prome = n1 = n2 = n3 = n4 = n5 = 0;
int opc = 0;
//string[] nums = {""};
float[] numer = {n1, n2, n3, n4, n5};

n1 = n2 = n3 = n4 = n5;

//do{

//}while(men = 6);

// elementos de prueba 10.5   6.8   10.22   14.33   22.1

Console.Clear();
//Console.Write("Dame 5 numeros separados por espacio:");
//nums = Console.ReadLine().Split();

Console.WriteLine("Menu:\nLeer  ..... [1]\nMostrar  .... [2]\nSuma y promedio [3]\n\nOpcion:");
opc = int.Parse(Console.ReadLine());

//do{
    switch(opc){
        case 1: 
            for(int i = 0; i < 5; i++){
                Console.Write($"Elemento {i + 1}: ");
                numer[i] = float.Parse(Console.ReadLine());
            //n1 = float.Parse(Console.ReadLine());
            //numer[i] = n1;
            }
            break;
        case 2:
            for(int i = 0; i < 5; i++){
                Console.WriteLine($"{numer[i]} "); }
            break;
        case 3:
            for(int i = 0; i < 5; i++){
                suma += numer[i];}
            Console.WriteLine($"La suma es: {suma}\nY el promedio: {suma/5}");
            break;
        case 4:
            float may, men;
            may = numer[0];
            men = numer[0];
            for(int i = 1; i < 5; i++){
                if(may < numer[i])
                    may = numer[i];
                if(men > numer[i])
                    men = numer[i];
            }
            Console.WriteLine($"\nEl numero menor es: {men}\nY el mayor es: {may}");
            break;
            case 5:
                Console.WriteLine("¿Qué numero busca?: ");
                bus = float.Parse(Console.ReadLine());
                for(int i = 0; i < 5; i++){
                    if(bus == numer[i])
                    Console.WriteLine($"El numero que buscas se encuentra en la posicion: {i + 1}");
                }
            break;
            case 6:
                return 0;
            break;
    }
//}while(opc == 6);