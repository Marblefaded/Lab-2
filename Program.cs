using Lab_2;
using System;


namespace Lab2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            RomanNumber[] values = new RomanNumber[5];

            Console.WriteLine("Operations:");
            var first = new RomanNumber(1);
            values[0] = (RomanNumber)first.Clone();
            var second = new RomanNumber(2);
            values[1] = (RomanNumber)second.Clone();
            Console.WriteLine(RomanNumber.Add((RomanNumber)first.Clone(), (RomanNumber)second.Clone()));
            var third = new RomanNumber(3);
            values[2] = (RomanNumber)third.Clone();
            Console.WriteLine(RomanNumber.Mul((RomanNumber)third.Clone(), (RomanNumber)second.Clone()));
            var four = new RomanNumber(4);
            values[3] = (RomanNumber)four.Clone();
            var five = new RomanNumber(10);
            values[4] = (RomanNumber)five.Clone();
            Console.WriteLine(RomanNumber.Add((RomanNumber)first.Clone(), (RomanNumber)second.Clone()));
            Console.WriteLine(RomanNumber.Sub((RomanNumber)five.Clone(), (RomanNumber)first.Clone()));
            Console.WriteLine(RomanNumber.Div((RomanNumber)five.Clone(), (RomanNumber)second.Clone()));

            Console.WriteLine("Sorted values:");

            Array.Sort(values);
            for (int i = 0; i < values.Length; i++)
            {
                Console.WriteLine(values[i]);
            }
        }
    }
}