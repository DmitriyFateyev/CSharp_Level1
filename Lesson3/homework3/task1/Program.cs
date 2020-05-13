using System;

// Студент: Дмитрий Фатеев

/* Задание №1
 * а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.
 * б) Дописать класс Complex, добавив методы вычитания и произведения чисел. Проверить работу класса.
 * в) Добавить диалог с использованием switch демонстрирующий работу класса.
 */


struct ComplexStruct
{
    public double im;
    public double re;

    public ComplexStruct Minus(ComplexStruct z2)     // a)
    {
        ComplexStruct z;
        z.im = im - z2.im;
        z.re = re - z2.re;
        return z;
    }

    //  в C# в структурах могут храниться также действия над данными
    public ComplexStruct Plus(ComplexStruct x)
    {
        ComplexStruct y;
        y.im = im + x.im;
        y.re = re + x.re;
        return y;
    }

    //  Пример произведения двух комплексных чисел
    public ComplexStruct Multi(ComplexStruct x)
    {
        ComplexStruct y;
        y.im = re * x.im + im * x.re;
        y.re = re * x.re - im * x.im;
        return y;
    }

    public override string ToString()
    {
        return re + (im > 0 ? "+" : "") + im + "i"; // -1 +- 2i ---> -1 - 2i
    }
}

class Complex
{
    double im;
    double re;

    public Complex()
    {
        im = 0;
        re = 0;
    }

    public Complex(double im, double re)
    {            
        this.im = im;
        this.re = re;
    }

    public Complex Plus(Complex x2)
    {
        Complex x3 = new Complex();
        x3.im = x2.im + im;
        x3.re = x2.re + re;
        return x3;
    }

    // Apply complex arithmetic rule: (a+bi)*(c+di)=(ac-bd)+(ad+bc)i
    public Complex Mult(Complex z2)
    {
        Complex z3 = new Complex();
        z3.re = (re * z2.re - im * z2.im);
        z3.im = (re * z2.im + im * z2.re);

        return z3;

    }

    public Complex Minus(Complex x2)
    {
        Complex x3 = new Complex();
        x3.im = im - x2.im;
        x3.re = re - x2.re;
        return x3;
    }

    // Свойства - это механизм доступа к данным класса.
    public double Im
    {
        get { return im; }
        set
        {
            if (value >= 0) im = value;
        }
    }

    public double Re
    {
        get { return re; }
        set
        {
            if (value >= 0) re = value;
        }
    }

    public override string ToString()
    {
        return re + (im > 0 ? "+" : "") + im + "i"; // -1 +- 2i ---> -1 - 2i
    }
}


class Program
{
    static void Main()
    {
        ComplexStruct complex1;
        complex1.re = 2;
        complex1.im = 3;

        ComplexStruct complex2;
        complex2.re = 1;
        complex2.im = 4;

        Console.WriteLine($"Применение структуры для работы с комплексными числами:");

        ComplexStruct result = complex1.Plus(complex2);
        Console.WriteLine($"{complex1.ToString()} + {complex2.ToString()} = {result.ToString()}");

        result = complex1.Minus(complex2);
        Console.WriteLine($"{complex1.ToString()} - {complex2.ToString()} = {result.ToString()}");

        result = complex1.Multi(complex2);
        Console.WriteLine($"{complex1.ToString()} * {complex2.ToString()} = {result.ToString()}");

        Console.WriteLine(Environment.NewLine);
        Console.WriteLine($"Применение класса для работы с комплексными числами");
        Console.WriteLine($"Выберите арифметическую операцию:\n1 - Сложение\n2 - Вычитание\n3 - Умножение");

        int.TryParse(Console.ReadLine(), out int operation);

        if(operation >= 1 && operation <= 3)
        {
            Complex z1 = new Complex(2, 3);
            Complex z2 = new Complex(1, 4);

            switch (operation)
            {
                case 1:
                    Console.WriteLine($"{z1.ToString()} + {z2.ToString()} = {z1.Plus(z2).ToString()}");
                    break;

                case 2:
                    z1.Im = 4; z1.Re = 8;
                    z2.Im = 2; z2.Re = 5;
                    Console.WriteLine($"{z1.ToString()} - {z2.ToString()} = {z1.Minus(z2).ToString()}");
                    break;

                case 3:
                    z1.Re = 1; z1.Im = 2;
                    z2.Re = 3; z2.Im = 4;
                    Console.WriteLine($"{z1.ToString()} * {z2.ToString()} = {z1.Mult(z2).ToString()}");
                    break;

                default:
                    break;
            }
        } else
        {
            Console.WriteLine($"Некорректный ввод данных");
        }
    }
}
