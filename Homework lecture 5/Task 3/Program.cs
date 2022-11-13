// Задача 3: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] CreateArray(int length)
{
    double[] tempArray = new double[length];
    for (int i = 0; i < length; i++)
    {
        tempArray[i] = new Random().Next(0, 100) + new Random().NextDouble();
    }
    return tempArray;
}
void PrintArray(double[] tempArray)
{
    Console.Write($"{tempArray[0]:f2}, ");
    for (int i = 1; i < tempArray.Length; i++)
    {
        Console.Write($"{tempArray[i]:f2}, ");
    }
}
double[]tempArray = CreateArray(8);
var max = tempArray[0];
var min = tempArray[0];
for (int i = 1; i < tempArray.Length; i++)
{
    if (tempArray[i] < min) min = tempArray[i];
    if (tempArray[i] > max) max = tempArray[i]; 
}
PrintArray(tempArray);
System.Console.WriteLine();
System.Console.WriteLine($"Разность между максимальным и минимальным элементами =  {max - min:f2}");