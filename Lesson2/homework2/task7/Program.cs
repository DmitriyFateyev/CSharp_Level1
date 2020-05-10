using System;

// Студент: Дмитрий Фатеев

/* Задание №7
 * a) Разработать рекурсивный метод, который выводит на экран числа от a до b (a<b);
 * б) (*)Разработать рекурсивный метод, который считает сумму чисел от a до b.
 */


class Program
{
    // a) Разработать рекурсивный метод, который выводит на экран числа от a до b(a<b);
    static void NumbersIntervalRecursive(int a, int b)
    {
        if(a == b)
        {
            Console.WriteLine(a);
        } else
        {
            Console.WriteLine(a);
            NumbersIntervalRecursive(a+1, b);
        }
    }

    // б) (*)Разработать рекурсивный метод, который считает сумму чисел от a до b.
    static int NumbersSumRecursive(int a, int b)
    {
        if (a < b)
            return a + NumbersSumRecursive(a + 1, b);
        else
            return a;
    }

    static void Main()
    {
        int a;
        int b;

        Console.WriteLine($"Рекурсивный метод, который выводит на экран числа от a до b (a<b)");

        Console.Write($"Введите число а:");
        a = int.Parse(Console.ReadLine());

        Console.Write($"Введите число b:");
        b = int.Parse(Console.ReadLine());

        NumbersIntervalRecursive(a, b);

        //----------------------------------------------------------------------------------------
        Console.WriteLine($"Рекурсивный метод, который считает сумму чисел от a до b");

        Console.Write($"Введите число а:");
        a = int.Parse(Console.ReadLine());

        Console.Write($"Введите число b:");
        b = int.Parse(Console.ReadLine());

        Console.WriteLine($"Сумма чисел: {NumbersSumRecursive(a, b)}");

        Console.ReadLine();
    }
}