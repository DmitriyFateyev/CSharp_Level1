using System;
using System.Text;
using System.Text.RegularExpressions;


static class Message
{
    // а) Вывести только те слова сообщения,  которые содержат не более n букв.
    public static void LessThan(string text, int count)
    {
        Regex regex = new Regex(@"\W\w{1," + count.ToString() + @"}\W"); //\s[a-zA-Z]{1,6}

        Match match = regex.Match(text);

        while (match.Success)
        {
            Console.WriteLine(match.Groups[0].Value);
            match = match.NextMatch();
        }
    }

    // б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
    public static void RemoveByEnding(string text, char symbol)
    {
        string pattern = "";

        if (char.IsLetter(symbol))
        {
            pattern = @"\w+" + symbol;   
        } else
        {
            pattern = @"\w+\" + symbol;
        }
        Regex regex = new Regex(pattern);
        Match match = regex.Match(text);

        text = regex.Replace(text, "!removed!");

        Console.WriteLine(text);
    }

    // в) Найти самое длинное слово сообщения.
    public static void LongestWord(string text)
    {
        int counter = 0;
        string pattern = @"\b\w{" + counter + @"}\b";
        Regex regex = new Regex(pattern);

        while (regex.IsMatch(text))
        {
           pattern = @"\b\w{" + counter++ + @"}\b";
           regex = new Regex(pattern);
        }
        counter=8;
        Console.WriteLine($"Самое длинное слово сообщения: {counter}");

        //regex = new Regex(@"\b\w{8}\b");
        regex = new Regex(@"\b\w{" + counter.ToString() + @"}\b");

        foreach (Match match in regex.Matches(text))
        {
            Console.WriteLine(match.Groups[0].Value);
        }
    }
}
