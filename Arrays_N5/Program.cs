using System;
/*
В массиве чисел найдите самый длинный подмассив из одинаковых чисел.
Дано 30 чисел. Вывести в консоль сам массив, число, которое само больше раз повторяется подряд и количество повторений.
Дополнительный массив не надо создавать.
Пример: {5, 5, 9, 9, 9, 5, 5} - число 9 повторяется большее число раз подряд
*/
namespace Arrays_N5
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 30;
            Random random = new Random();
            int[] a = new int[N];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = random.Next(1, 3);
                Console.Write($"{a[i],5}");
            }

            int k = 1;
            int max = 0;
            int maxN = -1;
            for (int i = 0; i < a.Length - 1; i++)
                if (a[i] == a[i + 1]) k++;
                else
                {
                    if (k > max)
                    {
                        max = k;
                        maxN = a[i];
                    }
                    k = 1;
                }
            Console.WriteLine();
            Console.WriteLine($"Max={max} Number={maxN}");



        }
    }
}
