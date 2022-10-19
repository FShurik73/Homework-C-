double a = Convert.ToDouble(Console.ReadLine());
double b = Convert.ToDouble(Console.ReadLine());
double c = Convert.ToDouble(Console.ReadLine());
double max = a;

if (max < b)
{
   max = b;
}
if (max < c)
{
    max = c;
}
Console.Write("max = ");
Console.WriteLine(max);
