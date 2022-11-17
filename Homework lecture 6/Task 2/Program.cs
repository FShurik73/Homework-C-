// Задача 2: Напишите программу, которая найдёт точку пересечения двух прямых,заданных уравнениями
//  y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)


double Promt(string msg)
{
    Console.Write(msg);
    double number = Convert.ToDouble(Console.ReadLine());
    return number;
}
void IntersectionPoint()
{
    double b1 = Promt("Введите b1:> ");
    double k1 = Promt("Введите k1:> ");
    double b2 = Promt("Введите b2:> ");
    double k2 = Promt("Введите k2:> ");
    double x = (b2-b1) / (k1-k2);
    double y = k1 * x + b1;
    x = Math.Round(x, 3);
    y = Math.Round(y, 3);
    Console.WriteLine($" Пересечение прямых в точке: ({x};{y})");
}
IntersectionPoint();

