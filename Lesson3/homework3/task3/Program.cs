using System;

// Студент: Дмитрий Фатеев

/* Задание №3
 * (*)Описать класс дробей — рациональных чисел, являющихся отношением двух целых чисел.
 * Предусмотреть методы сложения, вычитания, умножения и деления дробей.
 * Написать программу, демонстрирующую все разработанные элементы класса.
 * (*)Добавить свойства типа int для доступа к числителю и знаменателю;
 * (*)Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа;
 * (**)Добавить проверку, чтобы знаменатель не равнялся 0. Выбрасывать исключение ArgumentException("Знаменатель не может быть равен 0");
 * (***)Добавить упрощение дробей.
 * 
 */

class Program
{
    // Finding the LCD is important because fractions need to have the same denominator when you 
    // are doing Addition or Subtraction math with fractions.
    static int LCD(int a, int b)
    {
        int max = a * b;

        for (int i = 2; i <= max; i++)
        {
            if ((i % a == 0) && (i % b == 0))
            {
                return i;
            }
        }
        return 1;
    }

    static int GCD(int a, int b)
    {
        int max = a>= b ? a : b;

        for (int i = max -1; i >= 1 - 1; i--)
        {
            if ((a % i == 0) && (b % i == 0))
            {
                return i;
            }
        }
        return 1;
    }

    static void Factor(int number)
    {
        int divider = 2;
        if(number == 0)
        {
            Console.WriteLine($"0");
        } else
        {
            while(number != 1)
            {
                if(number % divider == 0)
                {
                    Console.Write($"{divider}  ");
                    number /= divider;
                } else
                {
                    divider++;
                }
            }
            Console.WriteLine(Environment.NewLine);
        }
    }

    static void Main()
    {
        do
        {
            Console.Write($"Введите числитель a1 = ");
            int.TryParse(Console.ReadLine(), out int a1);
            Console.Write($"Введите знаменатель b1 = ");
            int.TryParse(Console.ReadLine(), out int b1);

            Fraction r1 = new Fraction(a1, b1);

            Console.Write($"Введите числитель a2 = ");
            int.TryParse(Console.ReadLine(), out int a2);
            Console.Write($"Введите знаменатель b2 = ");
            int.TryParse(Console.ReadLine(), out int b2);

            Console.WriteLine(Environment.NewLine);

            Fraction r2 = new Fraction(a2, b2);

            Fraction result = r1.Add(r2); // r1 + r2 = a1/b2 + a2/b2
            Console.Write($"Сложение: {a1}/{b1} + {a2}/{b2} = {result.ToString()} = ");
            result = result.SimplifyRatio(result);
            Console.WriteLine(result.ToString());
            Console.WriteLine($"Десятичная дробь: {result.Decimal:F3}");
            Console.WriteLine(Environment.NewLine);

            result = r1.Substract(r2);  // r1 - r2 = a1/b2 - a2/b2
            Console.Write($"Вычитание: {a1}/{b1} - {a2}/{b2} = {result.ToString()} = ");
            result = result.SimplifyRatio(result);
            Console.WriteLine(result.ToString());
            Console.WriteLine($"Десятичная дробь: {result.Decimal:F3}");
            Console.WriteLine(Environment.NewLine);

            result = r1.Mult(r2);  // r1 * r2 = a1/b2 * a2/b2
            Console.Write($"Умножение: {a1}/{b1} * {a2}/{b2} = {result.ToString()} = ");
            result = result.SimplifyRatio(result);
            Console.WriteLine(result.ToString());
            Console.WriteLine($"Десятичная дробь: {result.Decimal:F3}");
            Console.WriteLine(Environment.NewLine);

            result = r1.Divide(r2);  // r1 * r2 = a1/b2 * a2/b2
            Console.Write($"Деление: {a1}/{b1} / {a2}/{b2} = {result.ToString()} = ");
            result = result.SimplifyRatio(result);
            Console.WriteLine(result.ToString());
            Console.WriteLine($"Десятичная дробь: {result.Decimal:F3}");
            Console.WriteLine(Environment.NewLine);
            
        } while (true);
    }
}