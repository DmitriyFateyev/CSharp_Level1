using System;

// Студент: Дмитрий Фатеев

/* Задание №5
 * а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает,
 * нужно ли человеку похудеть, набрать вес или все в норме;
 * б) (*)Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
 */


class Program
{
    #region Methods
    static void CalculateBMI(double weight, double height)
    {
        // I = m / (h * h); где m — масса тела в килограммах, h — рост в метрах.
        double BodyMassIndex = weight / Math.Pow(height, 2);
        double minNormal_BMI = 18.5;
        double maxNormal_BMI = 25;

        if (BodyMassIndex <= 16)
        {
            Console.WriteLine($"{BodyMassIndex:F2} кг/м2: Выраженный дефицит массы тела");
            Console.WriteLine($"Для нормализации веса, необходимо поправится на {Math.Ceiling((minNormal_BMI - BodyMassIndex) * height*height)}кг");
        }
        else if (BodyMassIndex >= 16 && BodyMassIndex <= minNormal_BMI)
        {
            Console.WriteLine($"{BodyMassIndex:F2} кг/м2: Недостаточная (дефицит) масса тела");
            Console.WriteLine($"Для нормализации веса, необходимо поправится на {Math.Ceiling((minNormal_BMI - BodyMassIndex) * height*height)}кг");
        }
        else if (BodyMassIndex >= minNormal_BMI && BodyMassIndex <= maxNormal_BMI)
        {
            Console.WriteLine($"{BodyMassIndex:F2} кг/м2: Норма");
        }
        else if (BodyMassIndex >= maxNormal_BMI && BodyMassIndex <= 30)
        {
            Console.WriteLine($"{BodyMassIndex:F2} кг/м2: Избыточная масса тела (предожирение)");
            Console.WriteLine($"Для нормализации веса, необходимо похудеть на {Math.Ceiling((BodyMassIndex - maxNormal_BMI) * height * height)}кг");
        }
        else if (BodyMassIndex >= 30 && BodyMassIndex <= 35)
        {
            Console.WriteLine($"{BodyMassIndex:F2} кг/м2: Ожирение первой степени");
            Console.WriteLine($"Для нормализации веса, необходимо похудеть на {Math.Ceiling((BodyMassIndex - maxNormal_BMI) * height * height)}кг");
        }
        else if (BodyMassIndex >= 35 && BodyMassIndex <= 40)
        {
            Console.WriteLine($"{BodyMassIndex:F2} кг/м2: Ожирение второй степени");
            Console.WriteLine($"Для нормализации веса, необходимо похудеть на {Math.Ceiling((BodyMassIndex - maxNormal_BMI) * height * height)}кг");
        }
        else if (BodyMassIndex >= 40)
        {
            Console.WriteLine($"{BodyMassIndex:F2} кг/м2: Ожирение третьей степени (морбидное)");
            Console.WriteLine($"Для нормализации веса, необходимо похудеть на {Math.Ceiling((BodyMassIndex - maxNormal_BMI) * height * height)}кг");
        }
        else
        {
            Console.WriteLine($"Проверьте правильность ввода данных!");
            Console.WriteLine($"Для нормализации веса, необходимо похудеть на {Math.Ceiling((BodyMassIndex - maxNormal_BMI) * height * height)}кг");
        }
    }
    #endregion


    static void Main()
    {
        Console.WriteLine($"Приложение расчета Индекса Массы Тела\n");

        Console.Write($"Введите вес(кг): ");
        double weight = Convert.ToDouble(Console.ReadLine().Replace('.', ','));

        Console.Write($"Введите рост(м): ");
        double height = Convert.ToDouble(Console.ReadLine().Replace('.', ','));

        CalculateBMI(weight, height);

        Console.ReadLine();
    }
}








