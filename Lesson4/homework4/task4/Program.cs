using System;
using System.IO;

// Студент: Дмитрий Фатеев

/* Задание №4
 * Решить задачу с логинами из урока 2, только логины и пароли считать из файла в массив.
 * Создайте структуру Account, содержащую Login и Password.
 */


class Program
{
    private struct Account
    {
        public string _login;
        public string _password;
    }

    static bool Authentication(string login, string password, Account[] userDB)
    {
        for (int i = 0; i < userDB.Length; i++)
        {
            if(login == userDB[i]._login)
            {
                if(userDB[i]._password == password)
                {
                    return true;
                }
            }
        }

        return false;
    }

    static Account[] ReadUsersFromFile(string path)
    {
        if (!(File.Exists(path)))
        {
            throw new FileNotFoundException("Не удалось открыть файл! Проверьте путь к файлу.");
        }
        else
        {
            int linesCount = File.ReadAllLines(path).Length;

            Account[] users = new Account[linesCount];

            System.IO.StreamReader sr = new System.IO.StreamReader(path);

            string line;
            for (int i = 0; i < linesCount; i++)
            {
                line = sr.ReadLine();
                string[] credentials = line.Split(':');
                users[i]._login = credentials[0];
                users[i]._password = credentials[1];
            }

            return users;
        }
    }

    static void Main()
    {
        
        bool isAuthenticated = false;
        int tryCount = 3;
        char key;
        string path = "../../users.txt";

        Account[] accounts = ReadUsersFromFile(path);

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

            isAuthenticated = Authentication(userLogin, userPassword, accounts);

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
