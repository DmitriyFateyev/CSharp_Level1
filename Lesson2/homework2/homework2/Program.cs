using System;

// Студент: Дмитрий Фатеев

/* Задание №1
 * Написать метод, возвращающий минимальное из трех чисел.
 */


class Program
{
    static int MinOfThreeNumbers(int a, int b, int c)
    {
        a = a <= b ? a : b;
        return a <= c ? a : c;
    }

    static void Main()
    {
        int firstNum = 0;
        int secondNum = 0;
        int thirdNum = 0;

        Console.Write("Введите первое число: ");
        firstNum = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите второе число: ");
        secondNum = Convert.ToInt32(Console.ReadLine());

        Console.Write("Введите третье число: ");
        thirdNum = Convert.ToInt32(Console.ReadLine());

        Console.Write($"Минимальное из трех чисел : {MinOfThreeNumbers(firstNum, secondNum, thirdNum)}");
        Console.ReadLine();
    }
}
