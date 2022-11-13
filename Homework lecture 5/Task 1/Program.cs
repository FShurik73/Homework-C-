//Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2


int[] CreateArray(int length)
{
    int[] tempArray = new int[length];
    for (int i = 0; i < length; i++)
    {
        tempArray[i] = new Random().Next(100, 1000);
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
int EvenNumber(int[] tempArray)
{
    int countEven = 0;
    foreach (int elment in tempArray)
    {
        if(elment % 2 ==0)
            countEven ++;
    }
    return countEven;
}
int[] tempArray = CreateArray(8);
PrintArray(tempArray);
System.Console.WriteLine($"-> {EvenNumber(tempArray)}");