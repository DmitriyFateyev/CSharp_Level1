using System;

// Дмитрий Фатеев

/*
 * Задание №6
 * (*)Создать класс с методами, которые могут пригодиться в вашей учебе (Print, Pause).
 */

class Program
{
    class tools
    {
        public void Pause()
        {
            Console.ReadLine();
        }

        public void Print(string ms)
        {
            Console.WriteLine(ms);
        }

        public void Print(string ms, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(ms);
        }

        public void Print(string ms, int x, int y, ConsoleColor clr)
        {
            Console.ForegroundColor = clr;
            Console.SetCursorPosition(x, y);
            Console.WriteLine(ms);
        }
    }

    static void Main()
    {
        tools t = new tools();

        t.Print("Задание №6. 1");
        t.Pause();

        t.Print("Задание №6. 2", Console.BufferWidth / 2, 1);
        t.Pause();

        t.Print("Задание №6. 3", Console.BufferWidth / 2, 2, ConsoleColor.Red);
        t.Pause();
    }
}