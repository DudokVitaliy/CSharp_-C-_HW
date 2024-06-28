namespace Inheritence_Indexers_HW
{
    abstract class Figure
    {
        public double SideA { get; set; }
        public Figure(double a)
        {
            SideA = a;
        }
        public abstract double GetArea();
        public abstract double GetPerimeter();
        public abstract void Print();
    }
    class Triangle : Figure
    {
        public double SideB { get; set; }
        public double SideC { get; set; }

        private double p;
        public Triangle(double a, double b, double c) : base(a)
        {
            SideB = b; SideC = c;
            p = (SideA + SideB + SideC) / 2;
        }
        public override double GetArea()
        {
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }
        public override double GetPerimeter()
        {
            return SideA + SideB + SideC;
        }
        public override void Print()
        {
            Console.WriteLine("\tTriangle");
            Console.WriteLine($"Side A = {SideA}\tSide B = {SideB}\tSide C = {SideC}");
        }
    }
    class Square : Figure
    {
        public Square(int a) : base(a) { }

        public override double GetArea()
        {
            return SideA * SideA;
        }
        public override double GetPerimeter()
        {
            return SideA * 4;
        }
        public override void Print()
        {
            Console.WriteLine("\tSquare");
            Console.WriteLine($"Side A = {SideA}");
        }

    }
    class Diamond : Figure
    {
        public double DiagA { get; set; }
        public double DiagB { get; set; }
        public Diamond(double a, double b) : base(0)
        {
            DiagA = a;
            DiagB = b;
        }
        public override double GetArea()
        {
            return (DiagA * DiagB) / 2;
        }
        public override double GetPerimeter()
        {
            return 2 * Math.Sqrt(DiagA * DiagA + DiagA * DiagA);
        }
        public override void Print()
        {
            Console.WriteLine("\tDiamond");
            Console.WriteLine($"Diagonal A = {DiagA}\tDiagonal B = {DiagB}");
        }
    }
    class Rectangle : Figure
    {
        public double SideB { get; set; }
        public Rectangle(double a, double b) : base(a)
        {
            SideB = b;
        }
        public override double GetArea()
        {
            return SideA * SideB;
        }
        public override double GetPerimeter()
        {
            return (SideA + SideB) * 2;
        }
        public override void Print()
        {
            Console.WriteLine("\tRectangle");
            Console.WriteLine($"Side A = {SideA}\tSide B = {SideB}");
        }
    }
    class Paralelogram : Figure
    {
        public double SideB { get; set; }
        public double Heigth { get; set; }
        public Paralelogram(int a, int b, int h) : base(a)
        {
            SideB = b; Heigth = h;
        }
        public override double GetArea()
        {
            return SideA * Heigth;
        }
        public override double GetPerimeter()
        {
            return (SideA + SideB) * 2;
        }
        public override void Print()
        {
            Console.WriteLine("\tParalelogram");
            Console.WriteLine($"Side A = {SideA}\tSide B = {SideB}\tHeigth = {Heigth}");
        }
    }
    class Trapeze : Figure
    {
        public double SideB { get; set; }
        public double SideC { get; set; }
        public double SideD { get; set; }
        public double Heigth { get; set; }
        public Trapeze(double a, double b, double c, double d, double h) : base(a)
        {
            SideB = b;
            SideC = c;
            SideD = d;
            Heigth = h;
        }
        public override double GetArea()
        {
            return (SideA + SideB) / 2 * Heigth;
        }
        public override double GetPerimeter()
        {
            return SideA + SideB + SideC + SideD;
        }
        public override void Print()
        {
            Console.WriteLine("\tTrapeze");
            Console.WriteLine($"Side A = {SideA}\tSide B = {SideB}\tSide C = {SideC}\tSide D = {SideD}\tHeigth = {Heigth}");
        }
    }
    class Circle : Figure
    {
        public Circle(double a) : base(a) { }
        public override double GetArea()
        {
            return 3.14 * (SideA * SideA);
        }
        public override double GetPerimeter()
        {
            return 2 * 3.14 * SideA;
        }
        public override void Print()
        {
            Console.WriteLine("\tCircle");
            Console.WriteLine($"Radius = {SideA}");
        }
    }
    class Ellipse : Figure
    {
        public double SideB { get; set; }
        public Ellipse(double a, double b) : base(a) 
        {
            SideB = b;
        }
        public override double GetArea()
        {
            return 3.14 * (SideA * SideB);
        }
        public override double GetPerimeter()
        {
            return 4 * ((3.14 * SideA * SideB + (SideA - SideB)) / (SideA + SideA));
        }
        public override void Print()
        {
            Console.WriteLine("\tEllipse");
            Console.WriteLine($"Semiaxis A = {SideA}\t Semiaxis B = {SideB}");
        }
    }
    class CompositeFigure
    {
        Figure[] figures;
        public CompositeFigure(params Figure[] f)
        {
            figures = f;
        }
        public void Print()
        {
            Console.WriteLine("\t\tAll elements:");
            foreach (var item in figures)
            {
                item.Print();
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            CompositeFigure comp_fig = new CompositeFigure ( new Triangle ( 1, 1, 1 ), new Square(2), new Diamond(3,3), new Rectangle(4,4), 
                new Paralelogram(5,5,5), new Trapeze(6,6,6,6,6), new Circle(7), new Ellipse(8,8));
            comp_fig.Print();
        }
    }
}
