// Задача 1: Задайте значения M и N. Напишите программу,
//  которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

void PrintNumbersEven(int m, int n)
{
    if (n < m)
    {
        return;
    }
    if (n % 2 == 0)
        PrintNumbersEven(m, n - 2);
    else
        PrintNumbersEven(m, n - 1);
    if (n % 2 == 0)
    {
        Console.WriteLine(n + " ");
    }
}

int m = 1;
int n = 9;
PrintNumbersEven(m, n);



