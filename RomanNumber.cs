using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_2
{

    public class RomanNumber : ICloneable, IComparable
    {
        private ushort n;
        private static ushort _value;

        public RomanNumber(ushort n)
        {
            this.n = n;
            _value = this.n;
            if (n == 0) throw new RomanNumberException();
        }
        public static RomanNumber Add(RomanNumber? n1, RomanNumber? n2)
        {
            _value = (ushort)(n1.n + n2.n);

            RomanNumber arrayed = new RomanNumber(_value);
            return arrayed;
        }
        public static RomanNumber Sub(RomanNumber? n1, RomanNumber? n2)
        {
            _value = (ushort)(n1.n - n2.n);

            RomanNumber arrayed = new RomanNumber(_value);
            return arrayed;
        }
        public static RomanNumber Mul(RomanNumber? n1, RomanNumber? n2)
        {

            _value = (ushort)(n1.n * n2.n);

            RomanNumber arrayed = new RomanNumber(_value);
            return arrayed;
        }
        public static RomanNumber Div(RomanNumber? n1, RomanNumber? n2)
        {

            _value = (ushort)(n1.n / n2.n);
            RomanNumber arrayed = new RomanNumber(_value);
            return arrayed;
        }
        public override string ToString()
        {
            ushort[] arrayone = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            string[] arrayletters = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            ushort i;
            i = 0;
            string s = "";


            while (n > 0)
            {
                if (arrayone[i] <= n)
                {
                    n -= arrayone[i];
                    s += arrayletters[i];
                }
                else i++;
            }
            return s;
        }
        public object Clone()
        {
            return new RomanNumber(n);
        }
        public int CompareTo(object? obj)
        {
            if (obj is RomanNumber next)
            {
                return (n).CompareTo(next.n);
            }
            else
            {
                throw new ArgumentException("Error");
            }
        }
    }
}

