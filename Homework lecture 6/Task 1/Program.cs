// Задача 1: Пользователь вводит с клавиатуры M чисел.
//  Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

int PromtInt(string strMessage)
{
    System.Console.Write(strMessage);
    int temp = int.Parse(System.Console.ReadLine());
    return temp;
}

int[] CreatArray(int length)
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
    foreach (int item in array)
    {
        System.Console.Write($"{item} ");
    }
    System.Console.WriteLine();
}

int ArrayNumbers(int[] myArray)
{
    int res = 0;
    for (int i = 0; i < myArray.Length; i++)
    {
        {
        if (myArray[i] > 0)
            res++;
        }
    }
    return res;
}

int ditgit = PromtInt("Введите длинну массива:> ");
int[] myArray = CreatArray(ditgit);
PrintArray(myArray);
System.Console.Write(ArrayNumbers(myArray));
System.Console.WriteLine();