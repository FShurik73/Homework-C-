// Задача 1: Напишите программу, которая принимает на вход пятизначное число и проверяет,
//  является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}
bool ValidateNumber(int num)
{
    if (num < 10000 || num > 100000)
    {
        System.Console.WriteLine("Число не пятизначное, введите другое число");
        return false;
    }
    return true;
}
int num = Prompt("Введите пятизначное число > ");
int value = num;
if (ValidateNumber(num))
{
    int result = 0;
    while (num > 0)
    {
        result = result * 10 + num % 10;
        num /= 10;
    }
    if (value == result)
    {
        System.Console.WriteLine($"{value} -> да");
    }
    else
    {
        System.Console.WriteLine($"{value} -> нет");
    }
}

