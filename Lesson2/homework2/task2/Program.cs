using System;

// Студент: Дмитрий Фатеев

/* Задание №2
 * Написать метод подсчета количества цифр числа.
 */


class Program
{
    static int NumberDigitsCount(double number)
    {
        return Math.Abs(number).ToString().Replace(",", "").Length;
    }

    static void Main()
    {
        double userNumber;
        bool isConversionSuccessful;

        Console.Write("Введите число: ");
        isConversionSuccessful = double.TryParse(Console.ReadLine().Replace('.', ','), out userNumber);

        if (isConversionSuccessful == true)
        {
            Console.WriteLine($"Количество цифр: {NumberDigitsCount(userNumber)}");
        } else
        {
            Console.WriteLine($"Некорректное значение числа!");
        }
    }
}
