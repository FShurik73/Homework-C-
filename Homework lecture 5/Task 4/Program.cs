// Задача 4 (*) При помощи рекурсии вывести последовательность чисел,
//  с заданым количеством этих чисел по принципу:
// Ввожу => 12
// 1 2 2 3 3 3 4 4 4 4 5 5

Console.Write("Введите число : ");
int n = Convert.ToInt32(Console.ReadLine());
int res = 0;
for (int i = 1; i <= n; i++)
{
    for (int j = 0; j < i; j++)
    {
        if (res <= n)
            res++;
        if (res > n)
            break;
        Console.Write($"{i} ");
    }
}