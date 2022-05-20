/*Напишите цикл, который принимает на вход
два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243
2, 4 -> 16
*/
Console.WriteLine("Введите число A: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число B: ");
int numB = Convert.ToInt32(Console.ReadLine());
int degree = 1;
for(int i=1; i <= numB; i++)
{
    degree *= numA;
}
Console.WriteLine($"A в степени B равняется: {degree}");
