namespace Delegates_HW
{
    using System.Reflection.Metadata.Ecma335;
    using static System.Console;
    public delegate int ResDeleg();
    public delegate void ChangeDeleg();
    class MyArray
    {
        int[] arr;
        public MyArray(int count)
        {
            arr = new int[count];
            for (int i = 0; i < count; i++)
            {
                arr[i] = new Random().Next(-10, 10);
            }
        }
        public void Print()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Write(arr[i] + "; ");
            }
            WriteLine();
        }
        //////////////////// 
        public int CountMinus()
        {
            int count = 0;
            for(int i = 0;i < arr.Length;i++)
            {
                if (arr[i] < 0)
                    count++;
            }
            return count;
        }
        public int Summa()
        {
            int summa = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                summa += arr[i];
            }
            return summa;
        }
        public int CountSimple()
        {
            int count = 0;
            bool simple = true;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 1)
                {
                    for (int j = 2; j <= arr[i] / 2; j++)
                    {
                        if (arr[i] % j == 0)
                        {
                            simple = false;
                            break;
                        }
                    }
                }
                else if (arr[i] < -1)
                {
                    for (int j = -2; j >= arr[i] / 2; j--)
                    {
                        if (arr[i] % j == 0)
                        {
                            simple = false;
                            break;
                        }
                    }
                }
                else
                {
                    simple = false;
                }
                if (simple)
                {
                    count++;
                    //WriteLine(arr[i]);
                }
                simple = true;
            }

            return count;
        }
        ///////////////////////////////////
        public void MinusToZero()
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < 0)
                    arr[i] = 0;
            }
        }
        public void Sort()
        {
            Array.Sort(arr);
        }
        public void Replace()
        {
            int[] new_arr = new int[arr.Length];
            int j = 0;
            for(int i = 0;i < arr.Length;i++)
            {
                if (arr[i] % 2 != 0)
                {
                    new_arr[j]  = arr[i];
                    j++;
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    new_arr[j] = arr[i];
                    j++;
                }
            }
            arr = new_arr;
        }
    }
    internal class Program
    {
        static public void NextMenu(int i)
        {
            int choise;
            if (i == 1)
            {
                WriteLine("\tSelect Operation");
                WriteLine("1 - count of negative elements");
                WriteLine("2 - sum of all elements");
                WriteLine("3 - the number of prime numbers");
                Write("Choise -> "); choise = int.Parse(ReadLine());
                Calculation(choise);
            }
            else if (i == 2)
            {
                WriteLine("\tSelect Operation");
                WriteLine("1 - change all negative elements to 0");
                WriteLine("2 - sort array");
                WriteLine("3 - move all even elements to the beginning");
                Write("Choise -> "); choise = int.Parse(ReadLine());
                Change(choise);
            }
            else
            {
                WriteLine("Wrong Select!"); 
            }
        }
        static public void Calculation(int i)
        {
            ResDeleg res;
            MyArray array = new MyArray(10);
            WriteLine("Your random array: ");
            array.Print();
            if (i == 1)
            {
                res = new ResDeleg(array.CountMinus);
                WriteLine($"Result: {res.Invoke()}");
            }
            else if (i == 2)
            {
                res = new ResDeleg(array.Summa);
                WriteLine($"Result: {res.Invoke()}");
            }
            else if (i == 3)
            {
                res = new ResDeleg(array.CountSimple);
                WriteLine($"Result: {res.Invoke()}");
            }
            else
            {
                WriteLine("Wrong Select!");
            }
        }
        static public void Change(int i)
        {
            MyArray array = new MyArray(10);
            WriteLine("Your random array: ");
            array.Print();
            if (i == 1)
            {
                ChangeDeleg res = new ChangeDeleg(array.MinusToZero);
                res.Invoke();
            }
            else if (i == 2)
            {
                ChangeDeleg res = new ChangeDeleg(array.Sort);
                res.Invoke();
            }
            else if (i == 3)
            {
                ChangeDeleg res = new ChangeDeleg(array.Replace);
                res.Invoke();
            }
            else
            {
                WriteLine("Wrong Select!");
            }
            WriteLine("Result:");
            array.Print();

        }
        static void Main(string[] args)
        {
            MyArray array = new MyArray(10);
            int choise = 1;
            while (choise != 0) 
                {
                    WriteLine("\tMENU");
                    WriteLine("1 - Calculation of the value");
                    WriteLine("2 - Array change");
                    WriteLine("0 - Exit");
                    Write("Choise -> "); choise = int.Parse(ReadLine());
                    NextMenu(choise);
                }
            WriteLine("Goodbye!");
        }
    }
}
