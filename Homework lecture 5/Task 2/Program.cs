// Задача 2: Задайте одномерный массив, заполненный случайными числами.
//  Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] CreateArray(int length)
{
    int[] tempArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        tempArray[i] = new Random().Next(-100, 100);
    }
    return tempArray;
}
void PrintArray(int[] array)
{
    Console.Write($"{array[0]}, ");
    for (int i = 1; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}
int SumEvenPosition(int[] tempArray)
{
    int numberEven = 0;
    for (int i = 1; i < tempArray.Length; i += 2)
    {
        numberEven += tempArray[i];
    }
    return numberEven;
}
int[]tempArray = CreateArray(8);
PrintArray(tempArray);
System.Console.WriteLine();
System.Console.WriteLine($"Сумма элементов стоящих на нечетных позициях -> {SumEvenPosition(tempArray)}");