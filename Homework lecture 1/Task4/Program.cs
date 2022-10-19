//Задача 4: Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

Console.Write("Введите число >");
int a = int.Parse(Console.ReadLine());
for (int count = 1; count <= a; count++)
{
    if (count % 2 == 0)
    {
        Console.Write(count + " ");
    }
}