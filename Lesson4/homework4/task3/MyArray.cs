using System;

/* а) Дописать класс для работы с одномерным массивом.
 * Реализовать конструктор, создающий массив определенного размера и заполняющий массив числами от 
 * начального значения с заданным шагом. 
 * Создать свойство Sum, которое возвращает сумму элементов массива,
 * метод Inverse, возвращающий новый массив с измененными знаками у всех элементов массива (старый
 * массив, остается без изменений),
 * метод Multi, умножающий каждый элемент массива на определённое число, 
 * свойство MaxCount, возвращающее количество максимальных элементов.
 * б)** Создать библиотеку содержащую класс для работы с массивом. Продемонстрировать работу библиотеки
 * е) *** Подсчитать частоту вхождения каждого элемента в массив (коллекция Dictionary<int,int>)
 */

class MyArray
{
    int[] a;

    public MyArray(int n, int el)
    {
        a = new int[n];
        for (int i = 0; i < n; i++)
            a[i] = el;
    }

    // Реализовать конструктор, создающий массив определенного размера и заполняющий массив числами от 
    // начального значения с заданным шагом.
    public MyArray(int size, int num, int step)
    {
        a = new int[size];

        for(int i=0; i<a.Length; i++)
        {
            a[i] = num;
            num += step;
        }
    }

    // Создать свойство Sum, которое возвращает сумму элементов массива,
    public int Sum
    {
        get
        {
            int sum = 0;
            for(int i=0; i<a.Length; i++)
            {
                sum += a[i];
            }
            return sum;
        }
    }

    // метод Inverse, возвращающий новый массив с измененными знаками у всех элементов массива (старый
    // массив, остается без изменений)
    public int[] Inverse()
    {
        int[] arrInverted = new int[a.Length];

        for(int i = 0; i < a.Length; i++)
        {
            arrInverted[i] = a[i] * -1;
        }

        return arrInverted;
    }

    // метод Multi, умножающий каждый элемент массива на определённое число
    public void Multi(int number)
    {
        for(int i=0; i<a.Length; i++)
        {
            a[i] *= number;
        }
    }



    /*
    public MyArray(int n, int min, int max)
    {
        a = new int[n];
        Random rnd = new Random();
        for (int i = 0; i < n; i++)
            a[i] = rnd.Next(min, max);
    }
    */

    public int Max
    {
        get
        {
            int max = a[0];
            for (int i = 1; i < a.Length; i++)
                if (a[i] > max) max = a[i];
            return max;
        }
    }

    public int Min
    {
        get
        {
            int min = a[0];
            for (int i = 1; i < a.Length; i++)
                if (a[i] < min) min = a[i];
            return min;
        }
    }

    public int CountPositiv
    {
        get
        {
            int count = 0;
            for (int i = 0; i < a.Length; i++)
                if (a[i] > 0) count++;
            return count;
        }
    }

    public override string ToString()
    {
        string s = "";
        foreach (int v in a)
            s = s + v + " ";
        return s;
    }
}