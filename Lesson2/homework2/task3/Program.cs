using System;

// Студент: Дмитрий Фатеев

/* Задание №3
 * С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
 */


class Program
{
    static void Main()
    {
        double userNumber = -1;
        double totalSum = 0;

        while(userNumber != 0)
        {
            Console.Write("Введите число: ");
            double.TryParse(Console.ReadLine().Replace('.', ','), out userNumber);

            if (userNumber > 0 && (userNumber % 2) != 0)     //Odd and not negative
            {
                totalSum += userNumber;
            }
        }

        if(totalSum == 0)
        {
            Console.WriteLine($"Положительные нечетные числа отсуствуют");
        } else
        {
            Console.WriteLine($"Сумма нечетных положительных чисел: {totalSum}");
        }

        Console.ReadLine();
    }
}
