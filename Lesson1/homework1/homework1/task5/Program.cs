using System;

// Дмитрий Фатеев

/* Задание №5
 *  а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
 *  б) Сделать задание, только вывод организуйте в центре экрана
 *  в) (*)Сделать задание б с использованием собственных методов (например, Print(string ms, int x,int y) 
 */

class Program
{
    static void Print(string ms, int x, int y)
    {
        Console.SetCursorPosition(x, y);
        Console.WriteLine(ms);
    }

    static void Main()
    {
        int screenCenter = Console.BufferWidth / 2;

        Console.ForegroundColor = ConsoleColor.Green;

        Print("Имя: \t Дмитрий", screenCenter, 0);
        Print("Фамилия: \t Фатеев", screenCenter, 1);
        Print("Город: \t Баку", screenCenter, 2);

        Console.ReadLine();
    }
}

