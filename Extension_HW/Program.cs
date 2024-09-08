
namespace Extension_HW
{
    using static System.Console;
    static class StringExtension
    {
        public static bool IsPalindrom(this string data)
        {
            bool result = true;
            for (int i = 0; i < data.Length / 2; i++)
            {
                if (data[i] != data[data.Length - i - 1])
                {
                    result = false; break;
                }

            }
            return result;
        }
        public static string ToEncode(this string data, int key)
        {
            char[] buffer = data.ToCharArray();

            for (int i = 0; i < buffer.Length; i++)
            {
                char letter = buffer[i];
                letter = (char)(letter + key);
                buffer[i] = letter;
            }
            return new string(buffer);
        }
        public static string ToDecode(this string data, int key)
        {
            char[] buffer = data.ToCharArray();

            for (int i = 0; i < buffer.Length; i++)
            {
                char letter = buffer[i];
                letter = (char)(letter - key);
                buffer[i] = letter;
            }
            return new string(buffer);
        }
    }
    static class ArrayExtension
    {
        public static int CountOfIdenticalElements(this int[] data)
        {
            int count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    if (data[i] == data[j])
                    {
                        count++;
                    }
                }
                for (int j = i + 1; j < data.Length; j++)
                {
                    if (data[i] == data[j])
                        count++;
                }
            }
            return count;
        }
        public static int CountOfElements(this int[] data, int elem)
        {
            int count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == elem)
                    count++;
            }
            return count;
        }
    }
        internal class Program
        {
        static void Main(string[] args)
        {
            string palindrom = "chuchahcuhc";

            if (palindrom.IsPalindrom())
                WriteLine("This is Palindrom");
            else
            {
                WriteLine("This is not Palindrom");
            }

            string word = "info";
            word = word.ToEncode(3);
            WriteLine(word);
            word = word.ToDecode(3);
            WriteLine(word);
            int[] array = { 1, 2, 3, 4, 5, 1 ,2 };
            // по суті це к-сть не унікальних елем
            WriteLine("Count of identical elements: " + array.CountOfIdenticalElements());
            WriteLine("Count of 1: " + array.CountOfElements(1));

        }
    }
    
}

