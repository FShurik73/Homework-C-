//Задача 2: Напишите программу, которая принимает на вход три числа и выдаёт 
//максимальное из этих чисел.

double a = Convert.ToDouble(Console.ReadLine());
double b = Convert.ToDouble(Console.ReadLine());
double c = Convert.ToDouble(Console.ReadLine());
double min, max;

if (a > b)
{
    if (a > c)
    {
        max = a;
    }
    else max = c;
}
else if (b > c)
{
    max = b;
}
else max = c;

if (a < b)
{
    if (a < c)
    {
        min = a;
    }
    else min = c;
}
else if (b < c)
{
    min = b;
}
else min = c;
Console.Write("max = ");
Console.WriteLine(max);