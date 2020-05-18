using System;
using System.Text.RegularExpressions;


// Студент: Дмитрий Фатеев

/* Задание №2
 * Разработать статический класс Message, содержащий следующие статические методы для обработки текста:
 * а) Вывести только те слова сообщения,  которые содержат не более n букв.
 * б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
 * в) Найти самое длинное слово сообщения.
 * г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
 * д) ***Создать метод, который производит частотный анализ текста. В качестве параметра в него передается массив слов и текст, 
 * в качестве результата метод возвращает сколько раз каждое из слов массива входит в этот текст. Здесь требуется использовать класс Dictionary.
 */


class Program
{
    static string exampleText = (@"Regular expressions provide a powerful, flexible, and efficient method for processing text. 
The extensive pattern-matching notation of regular expressions enables you to quickly parse large amounts of text to:
Find specific character patterns.
Validate text to ensure that it matches a predefined pattern (such as an email address).
Extract, edit, replace, or delete text substrings.
Add extracted strings to a collection in order to generate a report.
For many applications that deal with strings or that parse large blocks of text, regular expressions are an indispensable tool.");


    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Проверочное сообщение:");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine(exampleText);

        Console.WriteLine(Environment.NewLine);

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Вывести слова сообщения, которые содержат не более 5 букв.");
        Console.ForegroundColor = ConsoleColor.White;
        Message.LessThan(exampleText, 5);

        Console.WriteLine(Environment.NewLine);

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"Удалить из сообщения все слова, которые заканчиваются на заданный символ - 'e'");
        Console.ForegroundColor = ConsoleColor.White;
        Message.RemoveByEnding(exampleText, 'e');

        Console.WriteLine(Environment.NewLine);

        Console.ForegroundColor = ConsoleColor.Red;
        Message.LongestWord(exampleText);

        Console.ReadLine();
    }
}
