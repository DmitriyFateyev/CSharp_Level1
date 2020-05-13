using System;
using System.IO;

/* Задание №2
 * Реализуйте задачу 1 в виде статического класса StaticClass;
 * а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
 * б) (*) Добавьте статический метод для считывания массива из текстового файла. Метод должен возвращать массив целых чисел;
 * в) (**) Добавьте обработку ситуации отсутствия файла на диске.
 */

static class ModThreePairs
{
    public static void FindPairs(int[] array)
    {
        for (int i = 0; i < array.Length; i += 2)
        {
            if (((array[i] % 3 == 0) && (array[i + 1] % 3 != 0)) || ((array[i] % 3 != 0) && (array[i + 1] % 3 == 0)))
            {
                Console.WriteLine($"{array[i]} {array[i + 1]}");
            }

        }
    }


    public static int[] ReadFromFile(string path)
    {
        if (!(File.Exists(path)))
        {
            throw new FileNotFoundException("Не удалось открыть файл! Проверьте путь к файлу.");
        } else
        {
            int linesCount = File.ReadAllLines(path).Length;

            int[] arrNumbers = new int[linesCount];

            System.IO.StreamReader sr = new System.IO.StreamReader(path);

            string line;
            for (int i = 0; i < linesCount; i++)
            {
                line = sr.ReadLine();
                int.TryParse(line, out arrNumbers[i]);
                Console.WriteLine(line);
            }

            return arrNumbers;
        }
    }
}
