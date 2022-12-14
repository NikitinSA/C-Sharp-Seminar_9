/*Задайте значения M и N. Напишите программу, которая
выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8"*/

Console.Clear();

Console.Write("Введите число M: ");
int firstUserNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число N: ");
int secondUserNumber = Convert.ToInt32(Console.ReadLine());

string Number(int firstUserNumber, int secondUserNumber)
{
    if (firstUserNumber <= secondUserNumber)
    {
        return $"{firstUserNumber} " + Number(firstUserNumber + 1, secondUserNumber);
    }
    else
    {
        return String.Empty;
    }
}

Console.Write(Number(firstUserNumber, secondUserNumber));