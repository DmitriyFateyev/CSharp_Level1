using System;
using System.Text.RegularExpressions;

// Студент: Дмитрий Фатеев

/* Задание №1
 * Создать программу, которая будет проверять корректность ввода логина.
 * Корректным логином будет строка от 2 до 10 символов, содержащая только 
 * буквы латинского алфавита или цифры, при этом цифра не может быть первой:
 * а) без использования регулярных выражений;
 * б) **с использованием регулярных выражений.
 */

class Program
{
    static bool CheckLogin(string login)
    {
        if(login.Length < 2 || login.Length > 10)
        {
            Console.WriteLine($"Неправильная длина!");
            return false;
        } else if(login[0] >= '0' && login[0] <= '9')
        {
            Console.WriteLine($"Первый символ не может быть цифрой!");
            return false;
        } else
        {
            for(int i=0; i<login.Length; i++)
            {
                if(login[i] >= 'a' && login[i] <= 'z' || login[i] >= 'A' && login[i] <= 'Z' || login[i] >= '0' && login[i] <= '9')
                {
                    continue;
                } else
                {
                    Console.WriteLine(login[i]);
                    return false;
                }
            }
            return true;
        }
    }

    static bool CheckLoginRegex(string login)
    {
        if (login.Length < 2 || login.Length > 10)
        {
            Console.WriteLine($"Неправильная длина!");
            return false;
        } else
        {
            Regex rgx = new Regex(@"^[a-zA-Z]{2,10}");
            return rgx.IsMatch(login);
        }        
    }

    static void Main()
    {
        Console.WriteLine($"Длина логина от 2 до 10 символов, разрешены только буквы латинского алфавита или цифры, \nпри этом цифра не может быть первой");
        Console.Write($"Введите логин: ");
        string userInput = Console.ReadLine();

        bool isLoginCorrect = CheckLogin(userInput);

        if (isLoginCorrect)
        {
            Console.WriteLine($"{userInput} - соответсвует требованиям логина без использования регулярных выражений;.");
        }

        isLoginCorrect = false;
        isLoginCorrect = CheckLoginRegex(userInput);

        if (isLoginCorrect)
        {
            Console.WriteLine($"{userInput} - соответсвует требованиям логина c использования регулярных выражений;.");
        }

        Console.ReadLine();
    }
}
