/* Напишите программу, которая будет принимать на вход число и
возвращать сумму его цифр.
453 -> 12
45 -> 9*/

Console.Clear();

Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int Number(int numberN)
{
    if (numberN == 0) return 0;
    else return numberN % 10 + Number(numberN/10);
}
Console.WriteLine($"Сумма цифр в числе = {Number(numberN)}");