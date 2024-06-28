namespace OOP_intro_HW
{
    partial class Freezer
    {
        private string brand;
        public string Brand
        {
            set { brand = value; }
            get { return brand; }
        }
        private string model;
        public string Model
        {
            set { model = value; }
            get { return model; }
        }
        private string color;
        public string Color
        {
            set { color = value; }
            get { return color; }
        }
        private int power;
        public int Power
        {
            set
            {
                if (value >= 0)
                {
                    power = value;
                }
                else
                {
                    power = 0;
                }
            }
            get { return power; }
        }
        private int volume;
        public int Volume
        {
            set
            {
                if (value >= 0)
                {
                    volume = value;
                }
                else
                {
                    volume = 0;
                }
            }
            get { return volume; }
        }
        static int count;
        static int id;
        //public Freezer()
        //{
        //    brand = "empty";
        //    model = "empty";
        //    color = "empty";
        //    power = 0;
        //    volume = 0;
        //}
        public Freezer(string brand, string model, string color, int power, int volume)
        {
            this.brand = brand;
            this.model = model;
            this.color = color;
            Power = power;
            Volume = volume;
            count++;
            id++;
        }
        public Freezer() : this("empty", "empty", "empty", 0, 0) { }
        static Freezer()
        {
            count = 0;
            id = 1000;
        }
        
    }
    
    internal class Program
    {
        static void AddPower(ref Freezer f)
        {
            f.Power += 10;
        }
        static void Main(string[] args)
        {
            Freezer[] freezers = new Freezer[]{
                new Freezer ("Atlant", "model1", "black", 400, 300 ),
                new Freezer ("Sumsung", "model2", "silver", 600, 400 ),
                new Freezer ("Nord", "model3", "white", 700, 350 ),
                new Freezer ("Indesit", "model4", "grey", 900, 500 ),
                new Freezer ("Dnepr", "model5", "white", 200, 100 )
                };
            foreach (var item in freezers)
            {
                Console.WriteLine("--------------------------------------");
                item.Print();
                Console.WriteLine("--------------------------------------");
            }
            Console.WriteLine($"Count  = {Freezer.GetCount()}");
            AddPower(ref freezers[0]);
            Console.WriteLine("Add power:");
            Console.WriteLine(freezers[0]);
        }
    }
}
