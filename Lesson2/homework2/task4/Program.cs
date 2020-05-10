using System;

// Студент: Дмитрий Фатеев

/* Задание №4
 * Реализовать метод проверки логина и пароля. 
 * На вход подается логин и пароль. На выходе истина, если прошел авторизацию, и ложь, если не прошел 
 * (Логин: root, Password: GeekBrains). 
 * Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, 
 * программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками.
 */


class Program
{
    static bool Authentication(string login, string password)
    {
        return (login == "root" && password == "GeekBrains") ? true : false;
    }

    static void Main()
    {
        bool isAuthenticated = false;
        int tryCount = 3;
        char key;

        while (isAuthenticated != true && tryCount-- != 0)
        {
            string userLogin;
            string userPassword = "";

            Console.Write($"Введите логин: ");
            userLogin = Console.ReadLine();

            Console.Write($"Введите пароль: ");

            do
            {
                key = Console.ReadKey(true).KeyChar;
                if (key != '\r')
                {
                    userPassword += key;
                    Console.Write("*");     // password masking
                }
            } while (key != '\r');

            Console.WriteLine(Environment.NewLine);

            isAuthenticated = Authentication(userLogin, userPassword);

            if (isAuthenticated == true)
            {
                Console.WriteLine($"Добро пожаловать, {userLogin}!");
                break;
            }
            else
            {
                Console.WriteLine($"Проверьте правильность ввода данных! Осталось попыток: {tryCount}");
            } 
        }

        Console.ReadLine();
    }
}
