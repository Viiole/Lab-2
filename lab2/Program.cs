using System;

class Program
{
    static void Main()
    {
        RomanNumber first = new RomanNumber(1001);
        RomanNumber second = new RomanNumber(888);
        RomanNumber third = new RomanNumber(2);
        RomanNumber fourth = new RomanNumber(7);

        Console.WriteLine("first (1001 = MI): " + first.ToString());
        Console.WriteLine("second (888 = DCCCLXXXVIII): " + second.ToString());
        Console.WriteLine("third (2 = II): " + third.ToString());
        Console.WriteLine("fourth (7 = VII): " + fourth.ToString());
        Console.WriteLine("");

        Console.WriteLine("first + second = 1889 (MDCCCLXXXIX): " + RomanNumber.Add(second, third).ToString());
        Console.WriteLine("second - fourth = 881 (DCCCLXXXI): " + RomanNumber.Sub(second, third).ToString());
        Console.WriteLine("fourth * third = 14 (XIV): " + RomanNumber.Mul(fourth, third).ToString());
        Console.WriteLine("second / third = 444 (CDXLIV): " + RomanNumber.Div(fourth, third).ToString());
        Console.WriteLine("");

        Console.WriteLine("Sort:");
        RomanNumber[] numbers = { first, second, third, fourth };
        Array.Sort(numbers);

        foreach (RomanNumber number in numbers)
        {
            Console.WriteLine(number.ToString());
        }
    }
}