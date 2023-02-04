// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт 
// таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125
Console.WriteLine("Чтобы увидить таблицу кубов чисел от 1 до n(или от -1 до -n), введите число: ");
int n = int.Parse(Console.ReadLine());
if (n == 0)
{
    Console.WriteLine("Введите положительное или отрицательное число");
}
else if (n > 0)
{
    int count = 1;
    Console.Write($"{n} -> ");
    while (count < n)
    {
        Console.Write($"{Math.Pow(count, 3)}, ");
        count++;
    }
    if (count == n)
    {
        Console.Write($"{Math.Pow(count, 3)} ");
    }
}
else if (n < 0)
{
    int count = -1;
    Console.Write($"{n} -> ");
    while (count > n)
    {
        Console.Write($"{Math.Pow(count, 3)}, ");
        count--;
    }
    if (count == n)
    {
        Console.Write($"{Math.Pow(count, 3)} ");
    }
}