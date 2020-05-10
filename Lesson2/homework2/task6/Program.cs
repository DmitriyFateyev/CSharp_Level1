using System;

// Студент: Дмитрий Фатеев

/* (*)Задание №6
 * *Написать программу подсчета количества «Хороших» чисел в диапазоне от 1 до 1 000 000 000.
 * Хорошим называется число, которое делится на сумму своих цифр. 
 * Реализовать подсчет времени выполнения программы, используя структуру DateTime.
 */


class Program
{
    static void Main()
    {
        double sum;
        DateTime start = DateTime.Now;

        for (int i = 1; i <= 1000000; i++)                      
        {
            char[] arrNumber = i.ToString().ToCharArray();
            sum = 0;

            for (int j = 0; j < arrNumber.Length; j++)
            {
                sum += int.Parse(arrNumber[j].ToString());
            }

            if(i % sum == 0)
                Console.WriteLine(i);
        }
        
        Console.WriteLine(DateTime.Now - start);    // 12.88 sec
        Console.ReadLine();
    }
}
