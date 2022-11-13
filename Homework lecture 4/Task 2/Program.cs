// Задача 2: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Реализовать через функции.
//452 -> 11
//82 -> 10
//9012 -> 12

int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}
int n = Prompt("Введите число >  ");
int result = 0;
for (int i = n; i > 0; result += i % 10, i /= 10) ;
System.Console.WriteLine($"Сумма цифр числа {n} равна {result}");



