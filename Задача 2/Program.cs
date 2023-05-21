Console.Clear();
Console.Write("Введите 1 число ");
int n = int.Parse(Console.ReadLine()!);
Console.Write("Введите 2 число ");
int m = int.Parse(Console.ReadLine()!);
if(n > m)
    Console.Write($"max = {n} min = {m}");
    else 
    Console.Write($"max = {m} min = {n}");