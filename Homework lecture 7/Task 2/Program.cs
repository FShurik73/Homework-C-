// Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int Prompt(string msg)
{
    Console.WriteLine(msg);
    int i = Convert.ToInt32(Console.ReadLine());
    return i;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            System.Console.Write($"{matrix[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

int[,] CreateArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
    }
    return matrix;
}

void FindNumber(int[,] matr, int n, int m)
{
    if (n < matr.GetLength(0) && m < matr.GetLength(1))
    {
        Console.WriteLine($"Координатам [{n},{m}] соответствует чило {matr[n, m]}");
        return;
    }
    Console.WriteLine("Таких координат в массиве нет");
}

void Execute()
{
    int[,] matrix = new int[5, 6];
    int n = Prompt("Введите номер строки:> ");
    int m = Prompt("Введите номер столбца:> ");
    int[,]matr = CreateArray(matrix);
    PrintArray(matrix);
    FindNumber(matrix, n, m);
}
Execute();