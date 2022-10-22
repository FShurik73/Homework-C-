//  Задача 3: Напишите программу, которая принимает на вход число (N)
//   и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27. 
// 5 -> 1, 8, 27, 64, 125
// 3 -> 1, 8, 27 
// 5 -> 1, 8, 27, 64, 125

int Prompt(string message)
{
    System.Console.Write(message);   
    return int.Parse(Console.ReadLine());   
    }
int N = Prompt("Введите число больше 0>  ");
int value = N;
int num = 1; 
while (num <= N) 
{
    System.Console.Write($"{num}^3 -> {num*num*num}, ");
    num++; 
}
// for (int i = 1; i<=N; i++)  // цикл for
// {
//    System.Console.Write($"{i}^3 -> {Math.Pow(i,3)}, ");
// }



