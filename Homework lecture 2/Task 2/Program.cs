// Задача 2: Напишите программу, которая выводит случайное трёхзначное
// число и удаляет вторую цифру этого числа. Не использовать строки для расчета.
// 456 -> 46
// 782 -> 72
// 918 -> 98


int number = new Random().Next(10, 1000);

int firstDigit = number / 100;
int lastDigit = number % 10;
int newNamber = (firstDigit *10 + lastDigit);

System.Console.WriteLine($" {number} ->  {newNamber}");
