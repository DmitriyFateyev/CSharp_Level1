using System;

// Студент: Дмитрий Фатеев

/* Задание №2
 * Реализуйте задачу 1 в виде статического класса StaticClass;
 * а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
 * б) (*) Добавьте статический метод для считывания массива из текстового файла. Метод должен возвращать массив целых чисел;
 * в) (**) Добавьте обработку ситуации отсутствия файла на диске.
 */

class Program
{
    static void Main()
    {
        int[] arrNumber = new int[20];
        Random rnd = new Random();

        for (int i = 0; i < arrNumber.Length; i++)
        {
            arrNumber[i] = rnd.Next(-10000, 10000);
        }

        System.IO.StreamWriter sw = new System.IO.StreamWriter("../../data.txt");

        for(int i=0; i < arrNumber.Length; i++)
        {
            sw.WriteLine(arrNumber[i].ToString());
        }
        sw.Close();

        ModThreePairs.FindPairs(arrNumber);

        Console.WriteLine(Environment.NewLine);

        ModThreePairs.ReadFromFile("../../data.txt");

        Console.ReadLine();
    }
}