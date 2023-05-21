Console.Clear();
Console.Write("Введите 1 число ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите 2 число ");
int b = int.Parse(Console.ReadLine()!);
Console.Write("Введите 3 число ");
int c = int.Parse(Console.ReadLine()!);
if(a > b && a > c)
Console.Write ($"max = {a}");
if(b > a && b > c)
Console.Write ($"max = {b}");
if(c > a && c > b)
Console.Write ($"max = {c}");