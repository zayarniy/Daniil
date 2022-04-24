using System;
/*
 * Найти наибольший элемент матрицы A(10,10) и записать ноль в те ячейки, где он находятся. 
 * Вывести наибольший элемент, исходную и полученную матрицу.
Массив под измененную версию не нужен.
*/
namespace Array_N2
{
    class Program
    {

        static int Sum(int a,int b)
        {
            return a + b;
        }

        static int[,] Fill2DArray(int N,int M,int min,int max)
        {
            int[,] a = new int[N, M];
            Random random = new Random();
            for (int i = 0; i < N; i++)
                for (int j = 0; j < M; j++)
                    a[i, j] = random.Next(min, max+1);
            return a;
        }

        static int Max(int[,] a)
        {
            int max = a[0, 0];
            for (int i = 0; i < a.GetLength(0); i++)
                for (int j = 0; j < a.GetLength(1); j++)
                    if (a[i, j] > max) max = a[i, j];
            return max;
        }
            static void Print2DArray(int[,] a)
        {
            for (int i = 0; i < a.GetLength(0); i++)
            {
                for (int j = 0; j < a.GetLength(1); j++)
                    Console.Write($"{a[i, j],5}");
                Console.WriteLine();
            }
        }

        static void Set2DArray(int[,] a, int value)
        {
            for (int i = 0; i < a.GetLength(0); i++)
                for (int j = 0; j < a.GetLength(1); j++)
                    if (a[i, j] == value) a[i, j] = 0;

        }

        static void Main(string[] args)
        {
            int s = Sum(2, 2);
            int[,] a = Fill2DArray(10, 10, 1, 10);
            Print2DArray(a);
            //Print2DArray(Fill2DArray(5, 5, 1, 5));
            int max=Max(a);
            Set2DArray(a, max);
            Console.WriteLine();
            Print2DArray(a);
        }
    }
}
