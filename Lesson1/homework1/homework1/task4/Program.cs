using System;

// Студент: Дмитрий Фатеев

/*  Задание №4
 *  Написать программу обмена значениями двух переменных.
 *  а) с использованием третьей переменной;
 *  б) (*)без использования третьей переменной.
*/

class Program
{
    static void Main()
    {
        int a = 5;
        int b = 7;
        int tmp = 0;

        Console.WriteLine($"Обмен значениями двух переменных с использованием третьей переменной:");
        Console.WriteLine($"a = {a}, b = {b}, tmp = {tmp}");

        // а) с использованием третьей переменной;
        tmp = a;
        a = b;
        b = tmp;

        Console.WriteLine($"a = {a}, b = {b}, tmp = {tmp}\n");
        //Console.ReadLine();

        Console.WriteLine($"Обмен значениями двух переменных без использования третьей переменной:");
        Console.WriteLine($"a = {a}, b = {b}");
        // б) *без использования третьей переменной.
        a = a ^ b;
        b = b ^ a;
        a = a ^ b;

        Console.WriteLine($"a = {a}, b = {b}");
        Console.ReadLine();
    }
}

