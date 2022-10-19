//  Задача 4: Напишите программу, которая принимает на вход цифру, 
//  обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да 
// 7 -> да 
// 1 -> нет

int Prompt(string message)
{
    System.Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

bool ValidateNumber(int number)
{
    if (number < 0 || number > 7)
    {
        System.Console.WriteLine("Такого дня не существует");
        return false;
    }
    if (number < 6)
    {
        System.Console.WriteLine($"{number} -> нет");
    }
    else 
    {
        System.Console.WriteLine($"{number} -> да");
    }
    return true;
}
int number = Prompt("Введите  число >  ");
if (ValidateNumber(number));
