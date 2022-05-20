/*Напишите программу, которая принимает на вход  число и
выдает сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/
string GetNumber()
{
    return Console.ReadLine();
}
int GetSumOfDigits(string numStr)
{
    int number = int.Parse(numStr);
    int sum = 0;
    while( number > 0)
    {
        sum = sum + (number % 10);
        number = number / 10;
    }
    return sum;
}
Console.WriteLine("Введите число");
string num = GetNumber();
int sumDigits = GetSumOfDigits(num);
Console.WriteLine($"Сумма цифр числа равна: {sumDigits}");
