using System;
using System.IO;

// Студент: Дмитрий Фатеев

/* Задание №2
 * Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата.
 * а) Сделать меню с различными функциями и представить пользователю выбор, для какой функции и на каком отрезке находить
 * минимум. Использовать массив (или список) делегатов, в котором хранятся различные функции.
 * б) (*)Переделать функцию Load, чтобы она возвращала массив считанных значений. Пусть она возвращает минимум функции через 
 * параметр (с использованием модификатора out). 
 */


namespace DoubleBinary
{
    public delegate double Fn(double x);

    class Program
    {
        public static double F1(double x)
        {
            return x * x - 50 * x - 10; // x^2-50*x-10
        }

        public static double F2(double x)
        {
            return x * x + 4 * x - x;   // x^2+4*x-x
        }

        public static double F3(double x)
        {
            return x * x - Math.Cos(x); // x^2-cos(x)
        }

        

        // Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата.
        public static void SaveFunc(string fileName, Fn delegFunc, double a, double b, double h)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(delegFunc(x));
                x += h;// x=x+h;
            }
            bw.Close();
            fs.Close();
        }

        public static double Load(string fileName, out double minFunc)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            double min = double.MaxValue;
            double d;
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                // Считываем значение и переходим к следующему
                d = bw.ReadDouble();
                if (d < min) min = d;
            }
            bw.Close();
            fs.Close();
            minFunc = min; //возвращает минимум функции через параметр(с использованием модификатора out).
            return min;
        }

        static void Main(string[] args)
        {
            // Использовать массив (или список) делегатов, в котором хранятся различные функции.
            Fn[] functions = new Fn[3];

            functions[0] = new Fn(F1);
            functions[1] = new Fn(F2);
            functions[2] = new Fn(F3);

            Console.WriteLine($"*********** Программа нахождения минимума функции  ***********");            
            Console.WriteLine($"1) x^2-50*x-10");
            Console.WriteLine($"2) x^2+4*x-x");
            Console.WriteLine($"3) x^2-cos(x)\n");
            Console.Write($"Выберите функцию (1, 2 или 3):");

            int.TryParse(Console.ReadLine(), out int userInput);

            if(userInput < 1 || userInput > 3)
            {
                Console.WriteLine($"Некорректный выбор! Выход...");
                Console.ReadKey();
                return;
            } else
            {
                Console.WriteLine($"Выбрана функция номер {userInput}");
            }

            Console.WriteLine($"Введите начальное и конечное значение отрезка");
            Console.Write($"a = ");
            int.TryParse(Console.ReadLine(), out int a);
            Console.Write($"b = ");
            int.TryParse(Console.ReadLine(), out int b);

            
            SaveFunc("data.bin", functions[userInput-1], -100, 100, 0.5);
            Console.WriteLine(Load("data.bin",out double functionMinimum));
            Console.WriteLine($"Минимум функции: {functionMinimum}");
            
            Console.ReadKey();
        }
    }
}