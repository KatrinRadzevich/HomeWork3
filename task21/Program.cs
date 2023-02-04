// Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит
// расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Write("Введите координату A X: ");
double ax = double.Parse(Console.ReadLine());
Console.Write("Введите координату A Y: ");
double ay = double.Parse(Console.ReadLine());
Console.Write("Введите координату A Z: ");
double az = double.Parse(Console.ReadLine());

Console.Write("Введите координату B X: ");
double bx = double.Parse(Console.ReadLine());
Console.Write("Введите координату B Y: ");
double by = double.Parse(Console.ReadLine());
Console.Write("Введите координату B Z: ");
double bz = double.Parse(Console.ReadLine());
// AB = √(xb - xa)2 + (yb - ya)2 + (zb - za)2
double distance = Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2) + Math.Pow(bz - az, 2));

Console.WriteLine($"A ({ax}, {ay}, {az}); B ({bx}, {by}, {bz}) -> {distance}");
