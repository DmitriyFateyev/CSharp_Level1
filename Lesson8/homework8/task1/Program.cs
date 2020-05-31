using System;
using System.Reflection;

// Студент: Дмитрий Фатеев

/* Задание №1
 * С помощью рефлексии выведите все свойства структуры DateTime
 */

class Program
{
    static void Main()
    {
        Type myType = typeof(DateTime);
        PropertyInfo[] pi = myType.GetProperties();
        MethodInfo[] methods = myType.GetMethods();

        Console.WriteLine("=============== Properties ===============");
        for (int i = 0; i < pi.Length; i++)
            Console.WriteLine($"{i} : {pi[i]}");

        Console.WriteLine("================ Methods =================");
        for (int i = 0; i < methods.Length; i++)
            Console.WriteLine($"{i}: {methods[i]}");

        Console.WriteLine("=============== Parameters ===============");
        ParameterInfo[] par = methods[63].GetParameters();
        for (int i = 0; i < par.Length; i++)
            Console.WriteLine($"{i}: {par[i]}");

        Console.ReadLine();
    }
}
