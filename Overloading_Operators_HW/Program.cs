using Overloading_Operators_HW;
using System.Drawing;
using static System.Console;
namespace Overloading_Operators_HW
{

    class Square
    {
        private int a;

        public int A
        {
            get { return a; }
            set
            {
                if (value >= 0)
                {
                    a = value;
                }
                else
                {
                    a = 0;
                }
            }
        }
        public Square(int A) { this.A = A; }
        public Square() : this(0) { }
        public override string ToString()
        {
            return $"side A = {A}";
        }

        public override bool Equals(object? obj)
        {
            return obj is Square square &&
                   a == square.a &&
                   A == square.A;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(a, A);
        }

        /////////// ++/-- ///////////
        public static Square operator ++(Square s)
        {
            s.A++;
            return s;
        }
        public static Square operator --(Square s)
        {
            s.A--;
            return s;
        }
        /////////// +*-/ ///////////
        public static Square operator +(Square s1, Square s2)
        {
            return new Square(s1.A + s2.A);
        }
        public static Square operator -(Square s1, Square s2)
        {
            return new Square(s1.A - s2.A);
        }
        public static Square operator *(Square s1, Square s2)
        {
            return new Square(s1.A * s2.A);
        }
        public static Square operator /(Square s1, Square s2)
        {
            return new Square(s1.A / s2.A);
        }
        /////////// < > <= >= ==!= ///////////
        public static bool operator >(Square s1, Square s2)
        {
            return s1.A > s2.A;
        }
        public static bool operator <(Square s1, Square s2)
        {
            return s1.A < s2.A;
        }
        public static bool operator >=(Square s1, Square s2)
        {
            return s1.A >= s2.A;
        }
        public static bool operator <=(Square s1, Square s2)
        {
            return s1.A <= s2.A;
        }
        public static bool operator ==(Square s1, Square s2)
        {
            //return s1.A == s2.A;
            return s1.Equals(s2);
        }
        public static bool operator !=(Square s1, Square s2)
        {
            return !(s1 == s2);
        }
        /////////// true/false ///////////
        public static bool operator true(Square s)
        {
            return s.A >= 0;
        }
        public static bool operator false(Square s1)
        {
            return s1.A <= 0;
        }
        /////////// explicit/implicit ///////////
        public static implicit operator Rectangle(Square s)
        {
            return new Rectangle(s.A, s.A);
        }
        public static implicit operator int(Square s)
        {
            return s.A;
        }
    }
}
class Rectangle
{
    private int a;

    public int A
    {
        get { return a; }
        set
        {
            if (value >= 0)
            {
                a = value;
            }
            else
            {
                a = 0;
            }
        }
    }
    private int b;

    public int B
    {
        get { return a; }
        set
        {
            if (value >= 0)
            {
                a = value;
            }
            else
            {
                a = 0;
            }
        }
    }
    public Rectangle(int a, int b)
    {
        A = a;
        B = b;
    }
    public Rectangle() : this(0, 0) { }
    public override string ToString()
    {
        return $"side A = {A} \tside B = {B}";
    }

    public override bool Equals(object? obj)
    {
        return obj is Rectangle rectangle &&
               a == rectangle.a &&
               A == rectangle.A &&
               b == rectangle.b &&
               B == rectangle.B;
    }

    public override int GetHashCode()
    {
        return HashCode.Combine(a, A, b, B);
    }
    /////////// ++/-- ///////////
    public static Rectangle operator ++(Rectangle r)
    {
        r.A++;
        r.B++;
        return r;
    }
    public static Rectangle operator --(Rectangle r)
    {
        r.A--;
        r.B--;
        return r;
    }
    /////////// +*-/ ///////////
    public static Rectangle operator +(Rectangle r1, Rectangle r2)
    {
        return new Rectangle(r1.A + r2.A, r1.B + r2.B);
    }
    public static Rectangle operator -(Rectangle r1, Rectangle r2)
    {
        return new Rectangle(r1.A - r2.A, r1.B - r2.B);
    }
    public static Rectangle operator *(Rectangle r1, Rectangle r2)
    {
        return new Rectangle(r1.A * r2.A, r1.B * r2.B);
    }
    public static Rectangle operator /(Rectangle r1, Rectangle r2)
    {
        return new Rectangle(r1.A / r2.A, r1.B / r2.B);
    }
    /////////// < > <= >= ==!= ///////////
    public static bool operator >(Rectangle r1, Rectangle r2)
    {
        return (r1.A + r1.B) > (r2.A + r2.B);
    }
    public static bool operator <(Rectangle r1, Rectangle r2)
    {
        return (r1.A + r1.B) < (r2.A + r2.B);
    }
    public static bool operator >=(Rectangle r1, Rectangle r2)
    {
        return (r1.A + r1.B) > (r2.A + r2.B);
    }
    public static bool operator <=(Rectangle r1, Rectangle r2)
    {
        return (r1.A + r1.B) > (r2.A + r2.B);
    }
    public static bool operator ==(Rectangle r1, Rectangle r2)
    {
        return r1.Equals(r2);
    }
    public static bool operator !=(Rectangle r1, Rectangle r2)
    {
        return !(r1 == r2);
    }
    /////////// true/false ///////////
    public static bool operator true(Rectangle r)
    {
        return r.A >= 0 && r.B >= 0;
    }
    public static bool operator false(Rectangle r)
    {
        return r.A < 0 || r.B < 0;
    }
    /////////// explicit/implicit ///////////
    public static explicit operator Square(Rectangle r)
    {
        return new Square((r.A + r.B) / 2);
    }
    public static explicit operator int(Rectangle r)
    {
        return r.A + r.B;
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Square s1 = new Square(5);
            Square s2 = new Square(10);
            WriteLine($"operator + :: {s1 + s2}");
            WriteLine($"operator - :: {s1 - s2}");
            WriteLine($"operator ++ :: {s1++}");
            WriteLine($"operator -- :: {s1--}");
            if (s1 > s2)
            {

            }
        }
    }
}

