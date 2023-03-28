

void tablamul(int tabla, int n){
    Console.WriteLine($"Tabla del {tabla}");
    for(int i = 1; i< n; i++){
        Console.Writecd($"{tabla} x {i} = {tabla*i}");
        Console.WriteLine("");
    }
}

tablamul(5,3);