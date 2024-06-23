namespace Exception_Namespace
{
    using static System.Console;
    internal class Program
    {
        class CreditCard
        {
            private string number;
            public string Number ;
        }

        static void Main(string[] args)
        {

            Write("\tN1");
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
            Write("\tN2");

        }
    }
}
