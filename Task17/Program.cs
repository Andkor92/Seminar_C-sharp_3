// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

Console.WriteLine("Введите Х: ");
int X = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y: ");
int Y = Convert.ToInt32(Console.ReadLine());

if (X > 0 && Y > 0)
{
    Console.WriteLine("Плоскость 1");
}
else if (X > 0 && Y < 0)
{
    Console.WriteLine("Плоскость 2");
}
else if (X < 0 && Y > 0)
{
    Console.WriteLine("Плоскость 4");
}
else
{
    Console.WriteLine("Плоскость 3");
}
