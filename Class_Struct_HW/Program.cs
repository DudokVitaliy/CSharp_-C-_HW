namespace Class_Struct_HW
{
    using System.Xml.Linq;
    using static System.Console;
    using static System.Runtime.InteropServices.JavaScript.JSType;

    class Worker
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
        private int age;

        public int Age
        {
            get { return age; }
            set
            {
                if (value >= 16 && value < 56)
                    age = value;
                else
                    throw new Exception("Error! Age can`t be smaller then 16 and more then 56!");
            }
        }
        private double salary;

        public double Salary
        {
            get { return salary; }
            set {
                if (value >= 0)
                    salary = value;
                else
                    throw new Exception("Error! Salary can`t be > 0!");
            }
        }
        private DateTime data;

        public DateTime Data
        {
            get { return data; }
            set {
                if (value <= DateTime.Now)
                    data = value;
                else
                    throw new Exception("Error! Data can`t by in the future!");
            }
        }
        public Worker(string n, string sur, int a, double s, DateTime d)
        {
            Name = n; Surname = sur; Age = a; Salary = s; Data = d;
        }
        public Worker() : this("no name", "no surname", 16, 0.0, DateTime.Now) { }
        public void Print()
        {
            WriteLine($"Name: {Name}");
            WriteLine($"Surname: {Surname}");
            WriteLine($"Age: {Age}");
            WriteLine($"Salary: {Salary}");
            WriteLine($"Data: {Data}");
        }
        

    }
    internal class Program
    {
        static void Fill(out Worker w)
        {
            Worker temp = new Worker();
            try
            {            
                WriteLine("\tFill worker info:");
                Write("Name:\t\t"); temp.Name = ReadLine();
                Write("Surname:\t"); temp.Surname = ReadLine();
                Write("Age:\t\t"); temp.Age = int.Parse(ReadLine());
                Write("Salary:\t\t"); temp.Salary = double.Parse(ReadLine());
                Write("Data:\t\t"); temp.Data = DateTime.Parse(ReadLine());
                WriteLine("Filled successfully!");
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message);
                WriteLine("Now try again and be more careful!");
                Fill(out w);
            }
            finally
            {
                w = temp;
            }
        }
        static void Main(string[] args)
        {
            //Worker worker = new Worker();
            //worker.Print();
            //Fill(out worker);
            //worker.Print();
            Worker[] workers = new Worker[2];
            for (int i = 0; i < workers.Length; i++)
            {
                WriteLine($"------------- {i + 1}-th ----------------");
                Fill(out workers[i]);
                WriteLine("---------------------------------------");
            }
            WriteLine("\tAll workers:");
            foreach (var item in workers)
            {
                WriteLine("---------------------------------------");
                item.Print();
                WriteLine("---------------------------------------");
            }
        }
    }
}
