using System.Dynamic;
using System.Linq.Expressions;

namespace Delegates
{
    //class MyDelegate : Delegate  
    //{

    //}
    public delegate int IntDelegate(double value);

    public delegate void SetStringDeleg(string value);
    public delegate double DoubleDelegate();
    public delegate void VoidDelegate();
    class SuperClass
    {
        public void Print(string str)
        {
            Console.WriteLine(str + "!!!");
        }
        public static double GetKoef()
        {
            double res = new Random().NextDouble();
            return res;
        }
        public static double GetNumber()
        {
            return new Random().Next();
        }
        public void DoWork()
        {
            Console.WriteLine("I do some work!");
        }
        public void Test()
        {
            Console.WriteLine("I testing.....");
        }
    }
    public delegate double CalculatorDelegate(double x, double y);
    class Calculator
    {
        public double Add(double x, double y)
        {
            return x + y;
        }
        public double Sub(double x, double y)
        {
            return x - y;
        }
        public double Multy(double x, double y)
        {
            return x * y;
        }
        public double Div(double x, double y)
        {
            if (y != 0)
                return x / y;
            else
                throw new DivideByZeroException();
        }
    }
    public delegate int ChangeDelegate(int value);
   
    internal class Program
    {
        public static void ChangeElements(int[] arr, ChangeDelegate change)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = change(arr[i]);
            }
        }
        static int Sqr(int n)
        {
            return n * n;
        }
        static int Increment(int n)
        {
            return ++n;
        }
        static int Decrement(int n)
        {
            return --n;
        }
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };
            foreach (int i in arr)  Console.Write(i + "; "); Console.WriteLine();
            ChangeElements(arr, Sqr);
            foreach (int i in arr)  Console.Write(i + "; "); Console.WriteLine();
            ChangeElements(arr, Increment);
            foreach (int i in arr) Console.Write(i + "; "); Console.WriteLine();
            ChangeElements(arr, Decrement);
            foreach (int i in arr) Console.Write(i + "; "); Console.WriteLine();

            ChangeElements(arr, delegate(int v) { return v + 10; });
            foreach (int i in arr) Console.Write(i + "; "); Console.WriteLine();
            //LambdaExpression 
            ChangeElements(arr, v => --v);
            foreach (int i in arr) Console.Write(i + "; "); Console.WriteLine();
            /*
            Calculator calculator = new Calculator();
            CalculatorDelegate calcDelegate = null;
            calcDelegate += calculator.Add;
            calcDelegate += calculator.Div;
            calcDelegate += calculator.Sub;
            calcDelegate += calculator.Multy;
            foreach (var item in calcDelegate.GetInvocationList())
            {
                Console.WriteLine($"Res = {(item as CalculatorDelegate)!.Invoke(10, 100)}");
            }
            */
            /*
            Calculator calculator = new Calculator();
            double x, y;
            int key;
            do
            {
                CalculatorDelegate calcDelegate = null;
                Console.WriteLine("Enter first number ");
                x = double.Parse(Console.ReadLine()!);
                Console.WriteLine("Enter second number ");
                y = double.Parse(Console.ReadLine()!);
                Console.WriteLine("Add  - 1 ");
                Console.WriteLine("Sub  - 2 ");
                Console.WriteLine("Mult  - 3 ");
                Console.WriteLine("Divide  - 4 ");
                Console.WriteLine("Exit  - 0 ");
                key = int.Parse(Console.ReadLine()!);
                switch (key)
                {
                    case 1:
                        calcDelegate = new CalculatorDelegate(calculator.Add);
                        break;
                    case 2:
                        calcDelegate = new CalculatorDelegate(calculator.Sub);
                        break;
                    case 3:
                        calcDelegate = calculator.Multy;
                        break;
                    case 4:
                        calcDelegate = calculator.Div;
                        break;
                    case 0:
                        Console.WriteLine("Good  Buy");
                        break;
                    default:
                        Console.WriteLine("Error choice......");
                        break;
                }

                Console.WriteLine("Res = " + calcDelegate?.Invoke(x, y));
            } while (key != 0);


            //SuperClass superClass = new SuperClass();
            //SuperClass.GetKoef();
            //DoubleDelegate method = new DoubleDelegate(SuperClass.GetKoef);
            //Console.WriteLine(method?.Invoke());
            //DoubleDelegate[] arr = new DoubleDelegate[]
            //{
            //     SuperClass.GetKoef,
            //     SuperClass.GetNumber
            //};
            //Console.WriteLine(arr[0].Invoke());
            //Console.WriteLine(arr[1]());
            //SetStringDeleg stringDeleg = new SetStringDeleg(superClass.Print);
            //VoidDelegate voidDeleg = new VoidDelegate(superClass.DoWork);
            //stringDeleg.Invoke("Hellllllo");
            //voidDeleg();
            ////Delegate.Combine(method, SuperClass.GetNumber);
            //method += SuperClass.GetNumber;
            //method += SuperClass.GetNumber;
            //method += SuperClass.GetKoef;

            //foreach (var item in method.GetInvocationList())
            //{
            //    Console.WriteLine((item as DoubleDelegate)!.Invoke());
            //}
            */
        }
    }

}

