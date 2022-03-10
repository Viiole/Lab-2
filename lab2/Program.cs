using System;

class Program
{
    static void Main()
    {
        RomanNumber a = new RomanNumber(2459);
        RomanNumber b = new RomanNumber(2999);
        RomanNumber c = new RomanNumber(4);
        RomanNumber d = new RomanNumber(500);
        RomanNumber e = new RomanNumber(3999);

        Console.WriteLine("A = 2459 (MMCDLIX) = " + a.ToString());
        Console.WriteLine("B = 2999 (MMCMXCIX) = " + b.ToString());
        Console.WriteLine("C = 4 (IV) = " + c.ToString());
        Console.WriteLine("D = 500 (D) = " + d.ToString());
        Console.WriteLine("");

        Console.WriteLine("B + C = 3003 (MMMIII) = " + RomanNumber.Add(b, c).ToString());
        Console.WriteLine("B - C = 2995 (MMCMXCV) = " + RomanNumber.Sub(b, c).ToString());
        Console.WriteLine("D * C = 2000 (MM) = " + RomanNumber.Mul(d, c).ToString());
        Console.WriteLine("D / C = 125 (CXXV) = " + RomanNumber.Div(d, c).ToString());
        Console.WriteLine("");

        Console.WriteLine("Сортировка");
        RomanNumber[] numbers = { a, b, c, d };
        Array.Sort(numbers);

        foreach (RomanNumber number in numbers)
        {
            Console.WriteLine(number.ToString());
        }

        Console.WriteLine("");

        Console.WriteLine("Копирование");
        var f = (RomanNumber)c.Clone();
        Console.WriteLine(f.ToString());
    }
}