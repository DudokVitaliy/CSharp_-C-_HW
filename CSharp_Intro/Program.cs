namespace CSharp_Intro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("\t\tN1");
            Console.WriteLine("It's easy to win forgiveness for being wrong;\nbeing right is what gets you into real trouble.\nBjarne Stroustrup");
            
            Console.WriteLine("\t\tN2");
            Console.WriteLine("Enter 5 numbers: ");
            Console.Write("\t1-th: "); int num1 = int.Parse(Console.ReadLine());
            Console.Write("\t2-th: "); int num2 = int.Parse(Console.ReadLine());
            Console.Write("\t3-th: "); int num3 = int.Parse(Console.ReadLine());
            Console.Write("\t4-th: "); int num4 = int.Parse(Console.ReadLine());
            Console.Write("\t5-th: "); int num5 = int.Parse(Console.ReadLine());
            int sum = num1 + num2 + num3 + num4 + num5;
            int prod = num1 * num2 * num3 * num4 * num5;
            int max = num1;
            if (num2 > max)
                max = num2;
            if (num3 > max)
                max = num3;
            if (num4 > max)
                max = num4;
            if (num5 > max)
                max = num5;
            int min = num1;
            if (num2 < min)
                min = num2;
            if (num3 < min)
                min = num3;
            if (num4 < min)
                min = num4;
            if (num5 < min)
                min = num5;
            Console.WriteLine("All numbers:" + num1 + "; " + num2 + "; " + num3 + "; " + num4 + "; " + num5);
            Console.WriteLine("\tsum = " + sum);
            Console.WriteLine("\tprod = " + prod);
            Console.WriteLine("\tmax = " + max);
            Console.WriteLine("\tmin = " + min);
            
            Console.WriteLine("\t\tN3");
            Console.Write("\tEnter number: \t"); int num = int.Parse(Console.ReadLine());
            int a = num / 100000;
            int b = num / 10000 % 10;
            int c = num / 1000 % 10;
            int d = num / 100 % 10;
            int e = num / 10 % 10;
            int f = num % 10;
            Console.WriteLine("\tReverse: \t" + f + e + d + c + b + a);
            
            Console.WriteLine("\t\tN4");
            Console.WriteLine("\tStart: \t0"); 
            Console.Write("\tEnter end: \t"); int range_2 = int.Parse(Console.ReadLine());
            Console.WriteLine("\tResult: ");
            int range_1 = 0;
            int number1 = 0;
            int number2 = 1;
            Console.WriteLine("Result: ");
            Console.Write( $"{number1}; {number2}; ");
            while ((number1 + number2) < range_2)
            {
                range_1 = (number1 + number2);
                Console.Write(range_1 + "; ");
                number1 = number2;
                number2 = range_1;
            }
            Console.WriteLine();
            
            Console.WriteLine("\t\tN5");
            Console.Write("\tEnter start: \t"); int start = int.Parse(Console.ReadLine());
            Console.Write("\tEnter end: \t"); int end = int.Parse(Console.ReadLine());
            for (int i = start; i <= end; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(i);
                }
                Console.WriteLine();
            }
            
            Console.WriteLine("\t\tN6");
            Console.Write("\tEnter symbol: \t"); string symb = Console.ReadLine();
            Console.Write("\tEnter length: \t"); int length = int.Parse(Console.ReadLine());
            Console.Write("\tSelect direction (- or |): \t"); string dir = Console.ReadLine();
            if (dir == "-")
            {
                for (int i = 0; i < length; i++)
                {
                    Console.Write(symb);
                }
                Console.WriteLine();
            }
            else if (dir == "|")
            {
                for (int i = 0; i < length; i++)
                {
                    Console.WriteLine(symb);
                }
            }
            else
            {
                Console.WriteLine("Error! Wrong direction!");
            }
        }
    }
}
