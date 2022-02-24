using System;
using System.Collections.Generic;
using System.Text;

public class RomanNumber : ICloneable, IComparable
{
    private string romanNumber = "";
    private ushort number;

    public RomanNumber(ushort n)
    {
        number = n;
    }

    public static RomanNumber Add(RomanNumber? n1, RomanNumber? n2)
    {
        if(n1 == null || n2 == null)
        {
            throw new RomanNumberException("fail");
        }

        return new RomanNumber ((ushort)(n1.number + n2.number));
    }

    public static RomanNumber Sub(RomanNumber? n1, RomanNumber? n2)
    {
        if (n1 == null || n2 == null || n1.number - n2.number <= 0)
        {
            throw new RomanNumberException("fail");
        }

        return new RomanNumber((ushort)(n1.number - n2.number));
    }
 
    public static RomanNumber Mul(RomanNumber? n1, RomanNumber? n2)
    {
        if (n1 == null || n2 == null)
        {
            throw new RomanNumberException("fail");
        }
        return new RomanNumber((ushort)(n1.number * n2.number));
    }

    public static RomanNumber Div(RomanNumber? n1, RomanNumber? n2)
    {
        if (n1 == null || n2 == null || n1.number / n2.number <= 0)
        {
            throw new RomanNumberException("fail");
        }

        return new RomanNumber((ushort)(n1.number / n2.number));
    }

    public override string ToString()
    {
        return romanNumber;
    }

    public object Clone()
    {
        return new RomanNumber(number);
    }

    public int CompareTo(object? o)
    {
        
    }
}