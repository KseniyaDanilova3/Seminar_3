// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 
// и выдаёт номер четверти плоскости, в которой находится эта точка.

Console.WriteLine("Введите X Y:");
string xy = Console.ReadLine()!; // 5,7
string[] parts = xy.Split(' ');
int x = int.Parse(parts[0]);
int y = int.Parse(parts[1]);

if (x > 0 && y > 0)
{
    Console.WriteLine("1-я четверь");
}
else if (x < 0 && y > 0)
{
    Console.WriteLine("2-я четверь");
}
else if (x < 0 && y < 0)
{
    Console.WriteLine("3-я четверь");
}
else if (x > 0 && y < 0)
{
    Console.WriteLine("4-я четверь");
}
else
{
    Console.WriteLine("Неправильная точка! Не соответствует условию задачи");
}