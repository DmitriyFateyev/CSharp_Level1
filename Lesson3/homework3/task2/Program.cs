using System;

// Студент: Дмитрий Фатеев

/* Задание №2
 * а) С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке).
 *    Требуется подсчитать сумму всех нечётных положительных чисел.
 *    Сами числа и сумму вывести на экран, используя tryParse.
 */


class Program
{
    static void Main()
    {
        double userNumber = -1;
        double totalSum = 0;

        while (userNumber != 0)
        {
            Console.Write("Введите число: ");
            double.TryParse(Console.ReadLine().Replace('.', ','), out userNumber);

            if (userNumber > 0 && (userNumber % 2) != 0)     //Odd and not negative
            {
                totalSum += userNumber;
            }
        }

        if (totalSum == 0)
        {
            Console.WriteLine($"Положительные нечетные числа отсуствуют");
        }
        else
        {
            Console.WriteLine($"Сумма нечетных положительных чисел: {totalSum}");
        }

        Console.ReadLine();
    }
}