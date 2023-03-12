Console.Write("Введите N: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write($"{n} -> ");
for (int i = 1; i <= n; i++ ) {
    if (i == n) {
        Console.WriteLine($"{i*i}");    
    } else 
    {
        Console.Write($"{i*i},");
    }    
}