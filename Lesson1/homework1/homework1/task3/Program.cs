using System;

// Студент: Дмитрий Фатеев

/*  Задание №3
 *  а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле 
 *  r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).
 *  Вывести результат, используя спецификатор формата .2f(с двумя знаками после запятой);
*/

class Program
{
    static void Main(string[] args)
    {
        Console.Write($"Введите координату х1 точки а:");
        double x1 = Convert.ToDouble(Console.ReadLine());
        Console.Write($"Введите координату y1 точки а:");
        double y1 = Convert.ToDouble(Console.ReadLine());

        Console.Write($"Введите координату x2 точки b:");
        double x2 = Convert.ToDouble(Console.ReadLine());
        Console.Write($"Введите координату y2 точки b:");
        double y2 = Convert.ToDouble(Console.ReadLine());

        double vecLength = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

        Console.WriteLine($"Расстояние между точками: {vecLength:F2}");
        Console.ReadLine();
    }
}
