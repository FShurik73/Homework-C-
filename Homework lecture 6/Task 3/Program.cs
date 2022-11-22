// Задача 3. (*) Найдите максимальное значение в матрице по каждой строке, получите сумму этих максимумов.
// Затем найдите минимальное значение по каждой колонке,получите сумму этих минимумов. 
//Затем из первой суммы (с максимумами) вычтите вторую сумму(с минимумами)
// 1 2 3
// 3 4 5
// 3+5=8, 1+2+3=6, 8-6=2

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            System.Console.Write($" {matr[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

int[,] matrix = new int[4, 5];
int MaxNum(int[,] matrix)
{
    int summax = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int max = matrix[i, 0];
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] > max)
                max = matrix[i, j];
        }
        Console.Write($" {max} + ");
        summax = max + summax;
    }
    Console.WriteLine($" = {summax}");

    int summin = 0;
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int min = matrix[0, j];
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            if (matrix[i, j] < min)
                min = matrix[i, j];
        }
        summin = min + summin;
        Console.Write($" {min} + ");
    }
    Console.WriteLine($" = {summin}");

    int sumDiff = 0;
    sumDiff = summax - summin;
    Console.WriteLine($" {summax} - {summin} = {sumDiff}");
    return sumDiff;
}




FillArray(matrix);
System.Console.WriteLine($" разность максимальных и минимальных чисел =  {MaxNum(matrix)},  ");
PrintArray(matrix);
MaxNum(matrix);







