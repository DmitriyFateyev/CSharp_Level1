using System;
using System.Collections;
using System.IO;

// Студент: Дмитрий Фатеев

/* Задание №3
 * Переделать программу Пример использования коллекций для решения следующих задач:
 * а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
 * б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся (*частотный массив);
 * в) отсортировать список по возрасту студента;
 * г) (*)отсортировать список по курсу и возрасту студента;
 */

class Program
{
    static void Main(string[] args)
    {
        int[] Courses = new int[6];
        int courseFiveStudents = 0;
        int courseSixStudents = 0;
        // Создадим необобщенный список
        ArrayList list = new ArrayList();
        // Запомним время в начале обработки данных
        DateTime dt = DateTime.Now;
        StreamReader sr = new StreamReader("..\\..\\students_1.csv");
        while (!sr.EndOfStream)
        {
            try
            {
                string[] s = sr.ReadLine().Split(';');
                list.Add(s[1] + " " + s[0]);// Добавляем склееные имя и фамилию
                int age = int.Parse(s[5]);
                int course = int.Parse(s[6]);

                // а) Подсчитать количество студентов учащихся на 5 и 6 курсах;
                if (course == 5)
                {
                    courseFiveStudents++;
                }
                else if (course == 6)
                {
                    courseSixStudents++;
                }

                // б) подсчитать сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся (*частотный массив);
                if (age >= 18 && age <= 20)
                {
                    Courses[course-1]++;
                }                
            }
            catch
            {
            }
        }
        sr.Close();
        list.Sort();
        Console.WriteLine($"Всего студентов:{list.Count}");
        Console.WriteLine($"Студентов 5го курса:{courseFiveStudents}");
        Console.WriteLine($"Студентов 6го курса:{courseSixStudents}");
        Console.WriteLine($"Студенты в возрасте от 18 до 20 лет по курсам:");
        Console.WriteLine($"1й курс: {Courses[0]}");
        Console.WriteLine($"2й курс: {Courses[1]}");
        Console.WriteLine($"3й курс: {Courses[2]}");
        Console.WriteLine($"4й курс: {Courses[3]}");
        Console.WriteLine($"5й курс: {Courses[4]}");
        Console.WriteLine($"6й курс: {Courses[5]}");

        // Вычислим время обработки данных
        Console.WriteLine(DateTime.Now - dt);
        Console.ReadKey();
    }
}
