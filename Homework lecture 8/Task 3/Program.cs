// Задача 3: Задайте две матрицы. Напишите программу, которая будет находить
//  произведение двух матриц. Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
Random rnd = new Random();
int[,] CreateArray(int row, int col)
{
    int[,] matrix = new int[row, col];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(0, 10);
        }
    }
    return matrix;
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

int[,] DivMatrix(int[,] matrix1, int[,] matrix2)
{
    var matrix3 = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    if (matrix1.GetLength(1) == matrix2.GetLength(0))
    {
        for (int i = 0; i < matrix3.GetLength(0); i++)
        {
            for (int j = 0; j < matrix3.GetLength(1); j++)
            {
                matrix3[i, j] = 0;
                for (int n = 0; n < matrix1.GetLength(1); n++)
                {
                    matrix3[i, j] += matrix1[i, n] * matrix2[n, j];
                }
            }
        }
    }
    else
    {
        System.Console.WriteLine("Количество строк 1-го массива не равно количеству столбцов 2-го массива");
    }
    return matrix3;
}

void Execute()
{

    int[,] array = CreateArray(rnd.Next(2, 5), rnd.Next(2, 5));
    int[,] array2 = CreateArray(rnd.Next(2, 5), rnd.Next(2, 5));
    PrintArray(array);
    Console.WriteLine();
    PrintArray(array2);
    Console.WriteLine();
    PrintArray(DivMatrix(array, array2));
    //Console.ReadLine();
}
Execute();