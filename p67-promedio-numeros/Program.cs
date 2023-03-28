

float promedio(float n1, float n2, float n3){
    float suma = 0;

    suma = (n1+ n2 + n3)/3;

    return suma;
}

string[] nums;
float n1,n2,n3,prom;

Console.Clear();
Console.WriteLine("Dame 3 numeros separados por espacio");

nums = Console.ReadLine().Split();

Console.WriteLine(nums);

n1 = float.Parse(nums[0]); n2 = float.Parse(nums[1]);  n3 = float.Parse(nums[2]); 

prom = promedio(n1,n2,n3);

Console.WriteLine($"El promedio de los numeros es: {prom:f2}");