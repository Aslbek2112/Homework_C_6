using System;

class Program
{
    static void Main()
    {
        Console.Clear();
        Console.Write("Введите k1: ");
        double k1 = double.Parse(Console.ReadLine());

        Console.Write("Введите b1: ");
        double b1 = double.Parse(Console.ReadLine());

        Console.Write("Введите k2: ");
        double k2 = double.Parse(Console.ReadLine());

        Console.Write("Введите b2: ");
        double b2 = double.Parse(Console.ReadLine());

        if (k1 == k2)
        {
            Console.WriteLine("Прямые параллельны, пересечение не возможно.");
        }
        else
        {
            double x = (b2 - b1) / (k1 - k2);
            double y = k1 * x + b1;

            Console.WriteLine($"Прямые пересекаются в точке ({x}, {y})");
        }
    }
}
