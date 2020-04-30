using System;

// Студент: Дмитрий Фатеев

/*    Задание №2 
 *    Ввести вес и рост человека.
 *    Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); где m — масса тела в килограммах, h — рост в метрах.
 */

class Program
{
    static void Main()
    {
        Console.WriteLine($"Приложение расчета Индекса Массы Тела\n");

        Console.Write($"Введите вес(кг): ");
        double weight = Convert.ToDouble(Console.ReadLine());

        Console.Write($"Введите рост(м): ");
        double height = Convert.ToDouble(Console.ReadLine().Replace('.', ','));

        // I = m / (h * h); где m — масса тела в килограммах, h — рост в метрах.
        double BodyMassIndex = weight / Math.Pow(height, 2);

        Console.WriteLine($"Индекс Массы Тела: {BodyMassIndex:F2} кг/м2");

        Console.ReadLine();
    }
}

