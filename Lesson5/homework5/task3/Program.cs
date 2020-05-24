using System;
using System.Text;

// Студент: Дмитрий Фатеев

/*  Задание №3
 *  *Для двух строк написать метод, определяющий, является ли одна строка перестановкой другой.
 *  Например:
 *  badc являются перестановкой abcd.  
 */

class Program
{
    static bool CheckString(string first, string second)
    {
        if(first.Length != second.Length)
        {
            return false;
        }

        int a = 0;
        int b = 0;

        for(int i = 0; i < first.Length; i++)
        {
            a += first[i];
            b += second[i];
        }

        if(a == b)
        {
            return true;
        } else
        {
            return false;
        }
    }


    static void Main()
    {
        Console.WriteLine($"Определение является ли одна строка перестановкой другой");
        Console.Write($"Введите первую строку: ");
        string first = Console.ReadLine();
        
        Console.Write($"Введите вторую строку: ");
        string second = Console.ReadLine();

        if(CheckString(first, second))
        {
            Console.WriteLine($"В строках используется перестановка!");
        } else
        {
            Console.WriteLine($"В строках перестановка НЕиспользуется!");
        }

        Console.Read();
    }
}