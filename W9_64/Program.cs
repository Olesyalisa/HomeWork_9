/* Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

M = 1; N = 5. -> ""1, 2, 3, 4, 5""
M = 4; N = 8. -> ""4, 6, 7, 8"" */


Console.Write("Enter point one: ");
int pointOne = int.Parse(Console.ReadLine());

Console.Write("Enter point two: ");
int pointTwo = int.Parse(Console.ReadLine());

if (pointOne < pointTwo)
{
    for (int i = pointOne; i <= pointTwo; i++)

        Console.Write($" {i}");

    for (int i = pointTwo; i <= pointOne; i++)
        Console.Write($" {i}");
}
Console.WriteLine();
Console.WriteLine($"Point one = {pointOne}, Point two = {pointTwo}");
