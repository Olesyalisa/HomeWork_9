/* Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30 */


Console.Write("Starting point = ");
int start = int.Parse(Console.ReadLine());

Console.Write("And point = ");
int theAnd = int.Parse(Console.ReadLine());

int sum = 0;
for (int i = start; i <= theAnd; i++)
    sum += i;
Console.WriteLine($"Starting point = {start}, And point = {theAnd} Equals the amont = {sum}");
