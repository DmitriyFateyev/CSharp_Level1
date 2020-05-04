using System;

// Студент: Дмитрий Фатеев

/*    Задание №1
 *    Написать программу «Анкета». Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес). 
 *    В результате вся информация выводится в одну строчку.
 *    а) используя склеивание;
 *    б) используя форматированный вывод;
 *    в) используя вывод со знаком $.    
 */

class Questionary
{
    static void Main()
    {
        string startMsg = "Вас приветствует приложение \"Анкета\"! Последовательно ответьте на указанные вопросы.\n";

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.SetCursorPosition((Console.BufferWidth - startMsg.Length) / 2, 0);

        Console.WriteLine(startMsg);

        Console.ForegroundColor = ConsoleColor.White;
        Console.Write($"Имя: ");
        string Name = Console.ReadLine();

        Console.Write($"Фамилия: ");
        string lastname = Console.ReadLine();

        Console.Write($"Возраст: ");
        int age = int.Parse(Console.ReadLine());

        Console.Write($"Рост: ");
        int height = int.Parse(Console.ReadLine());

        Console.Write($"Вес: ");
        int weight = int.Parse(Console.ReadLine());

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\nАнкета заполнена.");
        Console.WriteLine($"Имя: {Name}\nФамилия: {lastname}\nВозраст: {age}\nРост: {height}\nВес: {weight}\n");

        Console.ForegroundColor = ConsoleColor.White;
        Console.ReadLine();
    }
}

