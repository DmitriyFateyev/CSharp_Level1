using System;

class Fraction
{
    private int _numerator;
    private int _denominator;

    public Fraction(int a = 1, int b = 1)
    {
        if (b == 0)
        {
           throw new ArgumentException($"Деление на нуль!");
        }
        else
        {
            _numerator = a;
            _denominator = b;
        }
    }

    public Fraction Add(Fraction r2)
    {
        Fraction r3 = new Fraction();

        // r1 + r2 = n1/d1 + n2/d2 = (n1 * d2 + n2 * d1) / (d1 * d2).
        r3._numerator = _numerator * r2._denominator + r2._numerator * _denominator;
        r3._denominator = _denominator * r2._denominator;

        return r3;
    }

    
    public Fraction Substract(Fraction r2)
    {
        Fraction r3 = new Fraction();

        // r1 - r2 = n1/d1 - n2/d2 = (n1 * d2 - n2 * d1) / (b1 * b2)
        r3._numerator = _numerator * r2._denominator - r2._numerator *_denominator;
        r3._denominator = _denominator * r2._denominator;

        return r3;
    }

    public Fraction Mult(Fraction r2)
    {
        Fraction r3 = new Fraction();

        //r1 * r2 = (n1 * n2) / (d1 * d2)
        r3._numerator = _numerator * r2._numerator;
        r3._denominator = _denominator * r2._denominator;

        return r3;
    }

    public Fraction Divide(Fraction r2)
    {
        Fraction r3 = new Fraction();

        //r1 / r2 = (n1 * d2) / (n2 * d1)
        r3._numerator = _numerator * r2.Denominator;
        r3._denominator = r2.Numerator * Denominator;

        if (r3._denominator == 0)
        {
            throw new ArgumentException($"Деление на нуль!");
        }

        return r3;
    }

    public Fraction SimplifyRatio(Fraction r)
    {
        int a = r._numerator;
        int b = r._denominator;

        int max = a >= b ? a : b;

        for (int i = max - 1; i >= 1 - 1; i--)
        {
            if ((a % i == 0) && (b % i == 0))
            {
                r._numerator /= i;
                r._denominator /= i;
                return r;
            }
        }
        return r;
    }

    // (*) Добавить свойства типа int для доступа к числителю и знаменателю;
    public int Numerator
    {
        get
        {
            return _numerator;
        }

        set
        {
            if (value.GetType() ==  typeof(int))
            {
                _numerator = value;
            } else
            {
                Console.WriteLine($"Число должно принадлежать множеству целых чисел!");
            }
        }
    }

    public int Denominator
    {
        get
        {
            return _denominator;
        }
        set
        {
            if (value.GetType() == typeof(int) && Denominator != 0)
            {
                _denominator = value;
            }
            else if(Denominator == 0)
            {
                Console.WriteLine($"Деление на нуль!");
            } 
        }
    }

    // (*)Добавить свойство типа double только на чтение, чтобы получить десятичную дробь числа;
    public double Decimal
    {
        get
        {
            return (double) _numerator / _denominator;
        }
    }

    public override string ToString()
    {
        return _numerator + "/" + _denominator;
    }
}
