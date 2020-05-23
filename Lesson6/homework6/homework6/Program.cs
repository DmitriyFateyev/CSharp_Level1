using System;

// Студент: Дмитрий Фатеев

/* Задание №1
 * Изменить программу вывода таблицы функции так, чтобы можно было передавать функции типа double (double, double). 
 * Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x).
 */


public delegate double Fun(double a, double x);

class Program
{
    public static void Table(Fun F, double a, double x, double b)
    {
        Console.WriteLine("----- X ----- Y -----");
        while (x <= b)
        {
            Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(a, x));
            x += 1;
        }
        Console.WriteLine("---------------------");
    }

    public static double myFunc(double a, double x)
    {
        return a * x * x;           // Продемонстрировать работу на функции с функцией a*x^2
    }

    public static double myFunc2(double a, double x)
    {
        return a * Math.Sin(x);     // Продемонстрировать работу на функции с функцией a*sin(x).
    }

    static void Main()
    {
        Console.WriteLine("Таблица функции a*x^2:");
        Table(new Fun(myFunc), 3, -2, 2);

        Console.WriteLine("Таблица функции a*sin(x)");     
        Table(myFunc2, 3, -2, 2);

        Console.ReadLine();
    }
}
