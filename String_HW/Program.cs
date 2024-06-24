namespace String_HW
{
    using System.Text;
    using static System.Console;
    internal class Program
    {
        static void Main(string[] args)
        {
            
            WriteLine("N1");
            Write("Enter first line: ");
            string str_1 = ReadLine();
            Write("Enter second line: ");
            string str_2 = ReadLine();
            Write("Enter position: ");
            int position = int.Parse(ReadLine());
            if (position >= str_1.Length)
            {
                WriteLine("Error! Incorrect position!");
            }
            else
            {
                WriteLine("First line: " + str_1);
                WriteLine("Second line: " + str_2);
                string str3 = str_1.Insert(position, str_2);
                WriteLine("Result: " + str3);
            }
            
            WriteLine("N2");
            Write("Enter line: ");
            string str_3 = ReadLine();
            char[] letters = new char [str_3.Length];
            int j = 0;
            for (int i = 0; i < str_3.Length; i++)
            {
                if (str_3[i] != ' ')
                {
                    letters[j] = str_3[i];
                    j++;
                }
            }
            WriteLine(str_3);
            WriteLine("Letters:");
            
            for (int i = 0; i < letters.Length; i++)
            {
                if (letters[i] == ' ')
                {
                    j = i - 1;
                    break;
                }
            }
            bool res = true;
            for (int i = 0; i < j; i++)
            {
                Write(letters[i] + "; ");
            }
            WriteLine();
            for (int i = 0; i < j/2; i++)
            {
                if (letters[i] != letters[j - i - 1])
                    res = false;
                break;   
            }
            if (res)
            {
                WriteLine("This is palindrom");
            }
            else
            {
                WriteLine("This is not palindrom");
            }
            
            WriteLine("N3");
            Write("Enter line: ");
            int count_all = 0;
            int count_low = 0;
            int count_up = 0;
            string str_4 = ReadLine();
            string[] words = str_4.Split(new char[] { ' ', ',', '.', ':', '!', '?', '-', '/' }, StringSplitOptions.RemoveEmptyEntries);
            foreach (string word in words)
            {
                Write(word + "::");
                for (int i = 0; i < word.Length; i++)
                {
                    count_all++;
                    if (char.IsLower(word[i]))
                    {
                        count_low++;
                    }
                    else if (char.IsUpper(word[i]))
                    {
                        count_up++;
                    }
                }
            }
            WriteLine();
            WriteLine("\tResults: ");
            WriteLine("all symbols: " + str_4.Length);
            WriteLine("all letters: " + count_all);
            WriteLine("all lower letters: " + count_low);
            WriteLine("all upper letters: " + count_up);
            WriteLine("\tPercent:");
            WriteLine("lower letters: " + ((count_low * 100)/ str_4.Length) + "%");
            WriteLine("upper letters: " + ((count_up * 100) / str_4.Length) + "%");
            
            WriteLine("N4");
            string []str_5 = new string []{"word", "day", "summer", "sun", "random", "string", "chinazes", "sunshine", "sunrise"};
            WriteLine("All words: ");
            foreach (var word in str_5)
            {
                Write(word + "; ");
            }
            WriteLine();
            Write("Enter length of word for change: ");
            int length = int.Parse(ReadLine());
            char[] symbols = new char[length];
            for (int i = 0; i < str_5.Length; i++)
            {
                if (str_5[i].Length == length)
                {
                    for (int x = 0; x < length; x++)
                    {
                        symbols[x] = str_5[i][x];
                    }
                    symbols[length - 1] = '$';
                    symbols[length - 2] = '$';
                    symbols[length - 3] = '$';
                    str_5[i] = "";
                    str_5[i] = string.Join("", symbols);


                }
            }
            WriteLine("Result: ");
            foreach (var word in str_5)
            {
                Write(word + "; ");
            }
            WriteLine();
            
            WriteLine("N5");
            Write("Enter line: ");
            string str_6 = ReadLine();
            string[] words_2 = str_6.Split(new char[] { ' ', ',', '.', ':', '!', '?', '-', '/' }, StringSplitOptions.RemoveEmptyEntries);
            Write("Enter number of word: ");
            int number = int.Parse(ReadLine());
            for (int i = 0; i < words_2.Length; i++)
            {
                if (i == number - 1)
                {
                    WriteLine("Result: " + words_2[i][0]);
                }
            }
            WriteLine("N6");
            Write("Enter line: ");
            string str_7 = ReadLine();
            string[] words_3 = str_7.Split(new char[] { ' ', ',', '.', ':', '!', '?', '-', '/' }, StringSplitOptions.RemoveEmptyEntries);
            string str_8 = string.Join('*', words_3);
            WriteLine("Result: " + str_8);
            
            WriteLine("N7");
            StringBuilder new_builder = new StringBuilder();
            WriteLine("\tEnter words: ");
            string one_word;
            while (true)
            {
                one_word = ReadLine();
                if (one_word == "")
                {
                    break;
                }
                else if (one_word[one_word.Length - 1] =='.' )
                {
                    new_builder.Append(one_word);
                    break;
                }
                else
                {
                    new_builder.Append(one_word + ", ");
                }
                one_word = "";
            }
            WriteLine("Result: " + new_builder);
        }
    }
}
