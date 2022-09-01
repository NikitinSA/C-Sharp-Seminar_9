/*Напишите программу, которая на вход принимает два числа A и B, и
возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8*/

Console.Clear();

Console.Write("Введите число A: ");
int firstUserNumber = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число B: ");
int secondUserNumber = Convert.ToInt32(Console.ReadLine());

int degree(int firstUserNumber, int secondUserNumber)
{
    return secondUserNumber == 0 ? 1 : degree(firstUserNumber, secondUserNumber - 1) * firstUserNumber;
}
Console.Write($"Число {firstUserNumber} в степени {secondUserNumber} = {degree(firstUserNumber, secondUserNumber)}");