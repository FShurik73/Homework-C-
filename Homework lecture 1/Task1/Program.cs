//Задача 1: Напишите программу, которая на вход принимает два числа и выдаёт,
// какое число большее, а какое меньшее

Console.WriteLine("Введите число a >");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b >");
int b = Convert.ToInt32(Console.ReadLine());
int max = 0;
int min = 0;
if (a > b)
{
    max = a;
    min = b;
}
else
{
    min = a;
    max = b;
}
Console.WriteLine($"max = {max},min = {min}");
