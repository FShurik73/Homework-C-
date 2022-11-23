// Задача 1: Задайте двумерный массив. Напишите программу, которая упорядочит 
// по убыванию элементы каждой строки двумерного массива. Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

void DescendingNumbers(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            for (int z = 0; z < matrix.GetLength(1) - 1; z++)
            {
                if (matrix[i, z] < matrix[i, z + 1]) //для изменения сортировки поменять знак < на противоположный
                {
                    int temp = 0;
                    temp = matrix[i, z];
                    matrix[i, z] = matrix[i, z + 1];
                    matrix[i, z + 1] = temp;
                }
            }
        }
    }
    Console.WriteLine();
}

void Execute()
{
    int[,] matrix = new int[4, 5];
    int[,] matr = CreateArray(matrix);
    PrintArray(matrix);
    DescendingNumbers(matrix);
    PrintArray(matrix);
}
Execute();


