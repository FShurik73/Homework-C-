// Задача 1: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

double Prompt(string message)
{
    System.Console.Write(message);
    return double.Parse(Console.ReadLine());
}

 double power(double x, double n)
{
    if(n == 0) return 1;
    if(n < 0) return power ( 1 / x, -n);
    if(n % 2 != 0) return x * power (x, n - 1);
    return power(x * x, n / 2);
}
double x = Prompt("Введите число a: ");
double n = Prompt("Введите число b: ");
double res = power(x,n);

System.Console.WriteLine($"Число {x} в степени {n} равно {res}");











