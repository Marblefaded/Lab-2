    using Lab_2;
    using System;



    class Program
    {
        public static void Main(string[] args)
        {
            RomanNumber num = new RomanNumber((ushort)3528), num1;

            Console.WriteLine(num);


            num = new RomanNumber((ushort)35);
            num1 = new RomanNumber((ushort)14);

            Console.WriteLine(num + num1);
            Console.WriteLine(num - num1);
            Console.WriteLine(num * num1);
            Console.WriteLine(num / num1);

            Random rand = new Random(1000);
            RomanNumber[] arrayofnum = new RomanNumber[10];


            for (int i = 0; i < 10; i++)
            {
                arrayofnum[i] = new RomanNumber((ushort)(2 + 2 * rand.Next(20)));
            }
            Array.Sort(arrayofnum);
            Console.WriteLine("Sorted:");

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(arrayofnum[i]);
            }
        }
    }