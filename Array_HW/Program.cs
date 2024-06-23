namespace Array_HW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            // N1 //
            {
                Console.WriteLine("\tN1");
                Console.Write("Enter count of elements: ");
                string count_str = Console.ReadLine();
                int count = int.Parse(count_str);
                int[] arr = new int[count];
                for (int i = 0; i < count; i++)
                {
                    Console.Write($"\t{i + 1}-th elem: ");
                    string count_elem = Console.ReadLine();
                    int elem = int.Parse(count_elem);
                    arr[i] = elem;
                }
                Console.WriteLine("All elements: ");
                foreach (var item in arr)
                {
                    Console.Write(item + "; ");
                }
                int even = 0;
                int odd = 0;
                int uniq = 0;
                foreach (var item in arr)
                {
                    if (item % 2 == 0)
                    {
                        even++;
                    }
                    else
                    {
                        odd++;
                    }
                }
                for (int i = 0; i < arr.Length; i++)
                {
                    bool isDuplicate = false;
                    for (int j = 0; j < i; j++)
                    {
                        if (arr[i] == arr[j])
                        {
                            isDuplicate = true;
                            break;
                        }
                    }
                    for (int j = i + 1; j < count; j++)
                    {
                        if (arr[i] == arr[j])
                        {
                            isDuplicate = true;
                            break;
                        }
                    }

                    if (!isDuplicate)
                    {
                        uniq++;
                    }
                }
                Console.WriteLine();
                Console.WriteLine("All even: " + even);
                Console.WriteLine("All odd: " + odd);
                Console.WriteLine("All uniq: " + uniq);
            }
            // N2 //
            {
                Console.WriteLine("\tN2");
                Console.Write("Enter count of elements: ");
                string count_str = Console.ReadLine();
                int count = int.Parse(count_str);
                int[] arr = new int[count];
                for (int i = 0; i < count; i++)
                {
                    Console.Write($"\t{i + 1}-th elem: ");
                    string count_elem = Console.ReadLine();
                    int elem = int.Parse(count_elem);
                    arr[i] = elem;
                }
                Console.WriteLine("All elements: ");
                foreach (var item in arr)
                {
                    Console.Write(item + "; ");
                }
                Console.WriteLine();
                Console.Write("Enter number: ");
                int num = int.Parse(Console.ReadLine());
                int count_small = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (arr[i] < num)
                    {
                        count_small++;
                    }
                }
                Console.WriteLine("Count smaller: " + count_small);
            }
            // N3 //
            {
                Console.WriteLine("\tN3");
                int count = 5;
                int[] A = new int[count];
                for (int i = 0; i < count; i++)
                {
                    Console.Write($"\t{i + 1}-th elem: ");
                    string count_elem = Console.ReadLine();
                    int elem = int.Parse(count_elem);
                    A[i] = elem;
                }
                Console.WriteLine("All elements A: ");
                foreach (var item in A)
                {
                    Console.Write(item + "\t");
                }
                Console.WriteLine();
                Random random = new Random();
                double[,] B = new double[3, 4];
                Console.WriteLine("All elements B: ");
                for (int i = 0; i < B.GetLength(0); i++)
                {
                    for (int j = 0; j < B.GetLength(1); j++)
                    {
                        B[i, j] = Math.Round(random.Next(10) + random.NextDouble(), 2);
                        Console.Write(B[i, j] + "\t");
                    }
                    Console.WriteLine();
                }
                Console.WriteLine();
                double max = A[0];
                double min = A[0];
                double sum = 0;
                double prod = 1;
                foreach (var item in A)
                {
                    if (item > max)
                    {
                        max = item;
                    }
                    if (item < min)
                    {
                        min = item;
                    }
                    sum += item;
                    prod *= item;
                }
                for (int i = 0; i < B.GetLength(0); i++)
                {
                    for (int j = 0; j < B.GetLength(1); j++)
                    {
                        if (B[i, j] > max)
                        {
                            max = B[i, j];
                        }
                        if (B[i, j] < min)
                        {
                            min = B[i, j];
                        }
                        sum += B[i, j];
                        prod *= B[i, j];

                    }
                }
                double even_sum = 0;
                double odd_col_sum = 0;
                for (int i = 0; i < A.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        even_sum += A[i];
                    }
                }
                for (int i = 0; i < B.GetLength(0); i++)
                {
                    for (int j = 0; j < B.GetLength(1); j++)
                    {
                        if (j % 2 != 0)
                        {
                            odd_col_sum += B[i, j];
                        }
                    }
                }
                sum = Math.Round(sum, 2);
                prod = Math.Round(prod, 2);
                Console.WriteLine("All max: " + max);
                Console.WriteLine("All min: " + min);
                Console.WriteLine("All sum: " + sum);
                Console.WriteLine("All prod: " + prod);
                Console.WriteLine("Sum even A : " + even_sum);
                Console.WriteLine("Sum odd col B: " + odd_col_sum);
            }

            // N4 //
            {
                Console.WriteLine("\tN4");
                Random random = new Random();
                int[,] arr = new int[5, 5];
                Console.WriteLine("All elements: ");
                int max = arr[0, 0];
                int max_i = 0;
                int max_j = 0;

                int min = arr[0, 0];
                int min_i = 0;
                int min_j = 0;

                for (int i = 0; i < arr.GetLength(0); i++)
                {
                    for (int j = 0; j < arr.GetLength(1); j++)
                    {
                        arr[i, j] = (random.Next(200) - 100);
                        Console.Write("\t" + arr[i, j]);
                        if (arr[i, j] > max)
                        {
                            max = arr[i, j];
                            max_i = i;
                            max_j = j;
                        }
                        if (arr[i, j] < min)
                        {
                            min = arr[i, j];
                            min_i = i;
                            min_j = j;
                        }
                    }
                    Console.WriteLine();
                }
                int summa = 0;
                Console.WriteLine("Max: [" + max + "] " + max_i + ":" + max_j);
                Console.WriteLine("Min: [" + min + "] " + min_i + ":" + min_j);
                if (max_i == min_i)
                {
                    if (max_j > min_j)
                    {
                        for (int j = min_j + 1; j < max_j; j++)
                        {
                            summa += arr[max_i, j];
                        }
                    }
                    else if (max_j < min_j)
                    {
                        for (int j = max_j + 1; j < min_j; j++)
                        {
                            summa += arr[max_i, j];
                        }
                    }
                }
                else if (max_i > min_i)
                {
                    for (int j = min_j + 1; j < arr.GetLength(1); j++)
                    {
                        summa += arr[min_i, j];
                    }
                    for (int j = 0; j < max_j; j++)
                    {
                        summa += arr[max_i, j];
                    }
                    for (int i = min_i + 1; i < max_i; i++)
                    {
                        for (int j = 0; j < arr.GetLength(1); j++)
                        {
                            summa += arr[i, j];
                        }
                    }
                }
                else if (min_i > max_i)
                {
                    for (int j = max_j + 1; j < arr.GetLength(1); j++)
                    {
                        summa += arr[max_i, j];
                    }
                    for (int j = 0; j < min_j; j++)
                    {
                        summa += arr[min_i, j];
                    }
                    for (int i = max_i + 1; i < min_i; i++)
                    {
                        for (int j = 0; j < arr.GetLength(1); j++)
                        {
                            summa += arr[i, j];
                        }
                    }
                }
                Console.WriteLine("Summa elements from min to max = " + summa);

                // N5 //
                {
                    Console.WriteLine("\tN4");
                    Random random2 = new Random();
                    int[,] arr2 = new int[5, 5];
                    int min2 = arr2[0, 0];
                    int count_diff = 0;
                    Console.WriteLine("All elements: ");
                    for (int i = 0; i < arr2.GetLength(0); i++)
                    {
                        for (int j = 0; j < arr2.GetLength(1); j++)
                        {
                            arr2[i, j] = (random2.Next(200) - 100);
                            Console.Write("\t" + arr2[i, j]);
                            if (arr2[i, j] < min2)
                            {
                                min2 = arr2[i, j];
                            }

                        }
                        Console.WriteLine();
                    }
                    for (int i = 0; i < arr2.GetLength(0); i++)
                    {
                        for (int j = 0; j < arr2.GetLength(1); j++)
                        {
                            if (arr2[i, j] + 5 == min2)
                            {
                                count_diff++;
                            }

                        }
                    }
                    Console.WriteLine("Min number = " + min2);
                    Console.WriteLine("Count of numbers greater that the min by 5 = " + count_diff);









                }
            }
        }
    }
}
