// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
// заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
// значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

void Main()
{
    Console.Clear();
    Console.Write("Enter k1: ");
    double k1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Enter b1: ");
    double b1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Enter k2: ");
    double k2 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Enter b2: ");
    double b2 = Convert.ToDouble(Console.ReadLine());
    IntersectionLines(k1, b1, k2, b2);
}

void IntersectionLines(double k01, double b01, double k02, double b02)
{
    double x = 0;
    double y = 0;

    if ((k01 == k02) && (b01 == b02))
    {
        Console.WriteLine($"Lines coincide: k1=k2, b1=b2");
    }
    else if (k01 == k02)
    {
        Console.WriteLine($"Lines are parallel: k1=k2");
    }
    else
    {
        x = Math.Round(((b02 - b01) / (k01 - k02)), 3);
        y = Math.Round(((k01 * (b02 - b01)) / (k01 - k02) + b01), 3);
        Console.WriteLine($"Intersection at a point: ({x};{y})");
    }
}
Main();