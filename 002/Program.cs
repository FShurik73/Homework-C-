// See https://aka.ms/new-console-template for more information

Console.Write("Введите число >");
int a = int.Parse(Console.ReadLine());
for (int count = 2; count <= a; count+= 2)
    {
        Console.Write(count + " ");
    }