/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

m = 2, n = 3 -> A(m,n) = 29 */

Console.Write("Enter point one: ");
int pointOne = int.Parse(Console.ReadLine());

Console.Write("Enter point two: ");
int pointTwo = int.Parse(Console.ReadLine());

int Ackerman(int pointOne, int pointTwo)
{
    if (pointOne == 0)
    {
        return pointTwo + 1;
    }

    if (pointOne != 0 && pointTwo == 0)
    {
        return Ackerman(pointOne - 1, 1);
    }

    if (pointOne > 0 && pointTwo > 0)
    {
        return Ackerman(pointOne - 1, Ackerman(pointOne, pointTwo - 1));
    }

    return Ackerman(pointOne, pointTwo);
}

Console.WriteLine($"The calculation of the Ackerman function is equal to = ({pointOne},{pointTwo}) = {Ackerman(pointOne, pointTwo)}");