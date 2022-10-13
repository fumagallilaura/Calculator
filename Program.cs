using System;

namespace Calculator
{
    class Program
    {
        static void Main (string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("What to do?\n1 - Sum\n2 - Subtration\n3 - Multiplication\n4 - Division\n5 - Exit");
            Console.WriteLine("-------------------");
            Console.WriteLine("Select option: ");

            short res = short.Parse(Console.ReadLine());
            switch (res)
            {
                case 1: Sum(); break;
                case 2: Sub(); break;
                case 3: Mult(); break;
                case 4: Div(); break;
                case 5: Environment.Exit(0); break;
                default: Menu(); break;
            }


            Console.ReadKey();
        }
        #region Counts
        static void Sum()
        {
            Console.Clear();
            Console.WriteLine("First value: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Second value: ");
            float v2 = float.Parse(Console.ReadLine());
            Console.WriteLine($"Result sum: {v1+v2}");
            Console.ReadKey();

            Menu();
        }
        static void Sub()
        {
            Console.Clear();

            Console.WriteLine("First value: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Second value: ");
            float v2 = float.Parse(Console.ReadLine());

            float result = v1 - v2;
            Console.WriteLine($"Result subtration: {result}");

            Console.ReadKey();

            Menu();
        }
        static void Mult()
        {
            Console.Clear();

            Console.WriteLine("First value: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Second value: ");
            float v2 = float.Parse(Console.ReadLine());

            float result = v1 * v2;
            Console.WriteLine($"Result multiplication: {result}");

            Console.ReadKey();

            Menu();
        }
        static void Div()
        {
            Console.Clear();

            Console.WriteLine("First value: ");
            float v1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Second value: ");
            float v2 = float.Parse(Console.ReadLine());

            float result = v1 / v2;
            Console.WriteLine($"Result division: {result}");

            Console.ReadKey();

            Menu();
        }
        #endregion
    }
}