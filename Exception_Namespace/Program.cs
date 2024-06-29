namespace Exception_Namespace
{
    using System;
    using System.Data;
    using static System.Console;
    using static System.Runtime.InteropServices.JavaScript.JSType;

    class CreditCard
    {
        private string name;

        public string Name
        {
            get { return name; }
            set { if (!string.IsNullOrEmpty(value))
                    name = value;
                else
                    throw new Exception("Error! Name can`t be empty!");
            }
        }
        private string surname;

        public string Surname
        {
            get { return surname; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                    surname = value;
                else
                    throw new Exception("Error! Surname can`t be empty!");
            }
        }
        private string number;

        public string Number
        {
            get { return number; }
            set
            {
                if (value.Length < 16 || value.Length > 16)
                    throw new Exception("Error! Card number must be 16!");
                else if (!(long.Parse(value) is long))
                    throw new Exception("Error! Card number can`t has letters!");
                else
                    number = value;
            }
        }
        private int cvv;

        public int Cvv
        {
            get { return cvv; }
            set { if (value > 999 || value < 100)
                    throw new Exception("Error! CVV code can has only 3 numbers!");
                else
                    cvv = value;
            }
        }
        private DateTime date;

        public DateTime Date
        {
            get { return date; }
            set { if (value >= DateTime.Now)
                    date = value;
                else
                    //date = value;
                    throw new Exception("Error! The Validity period of the card has expired!");
            }
        }
        public CreditCard(string name, string surname, string number, int cvv, DateTime date)
        {
            Name = name;
            Surname = surname;
            Number = number;
            Cvv = cvv;
            Date = date;
        }
        public CreditCard() : this("empty", "empty", "0000000000000000", 111, new DateTime (9999,12,12)) { }
        public void Print()
        {
            WriteLine("\tCard info:");
            WriteLine($"\tName: {Name}\t{Surname}");
            WriteLine($"\tCard number: {Number}");
            WriteLine($"\tCVV: {Cvv}");
            WriteLine($"\tValid until: {Date.ToShortDateString()}");
        }
        public void FillInfo()
        {
            try
            {
                WriteLine("\tFill card info:");
                Write($"Name:"); Name = ReadLine();
                Write($"Surname:"); Surname = ReadLine();
                Write($"Card number:"); Number = ReadLine();
                Write($"CVV:"); Cvv = int.Parse(ReadLine());
                Write($"Valid until:"); Date = DateTime.Parse(ReadLine());
                WriteLine("Filled successfully!");
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message);
                WriteLine("Now try again and be more careful!");
                FillInfo();
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            
            WriteLine("\tN1");
            Write("Enter number: ");
            int number;
            try
            {
                checked
                { 
                    number = int.Parse(ReadLine());
                }
            }
            catch(OverflowException ex)
            {
                WriteLine(ex.Message);
            }
            catch(Exception ex)
            {
                WriteLine("Error! Wrong data!");
            }
            
            WriteLine("\tN2");
            CreditCard card = new CreditCard();
            card.Print();
            card.FillInfo();
            card.Print();
            
            WriteLine("\tN3");
            bool next = true;
            Write("Enter line (int * int * int...):");
            string line = ReadLine();
            string[] numbers = line.Split('*', StringSplitOptions.RemoveEmptyEntries);
            int[] num = new int[numbers.Length];
            try
            {
                for (int i = 0; i < numbers.Length; i++)
                {
                    try
                    {
                        checked
                        {
                            num[i] = int.Parse(numbers[i]);
                        }
                    }
                    catch (OverflowException ex)
                    {
                        WriteLine(ex.Message);
                    }
                    catch (Exception ex)
                    {
                        WriteLine("Error! Wrong data type!");
                        next = false;
                    }
                }
            }
            catch (Exception ex)
            {
                WriteLine("Other Error!");
                next = false;
            }
            int result = 1;
            if (next)
            {
                for (int i = 0; i < num.Length; i++)
                {
                    result *= num[i];
                }
                WriteLine("Result = " + result);
            }


        }
    }
}
