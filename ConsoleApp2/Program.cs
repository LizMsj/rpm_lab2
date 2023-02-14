using System;

class Consol
{
    static void Main()
    {

        Random rnd = new Random();
        Console.Write("Размерность матрицы: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[,] nums1 = new int[n, n];
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
                nums1[i, j] = rnd.Next(-100, 100);
        }
        Console.WriteLine("Сгенерирована матрица размерностью " + n + "*" + n);
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
                Console.Write($"{nums1[i, j]}\t");
            Console.WriteLine();
        }
        Console.Write("Введите число для сравнения: ");
        int pp = Convert.ToInt32(Console.ReadLine());

        int[] mas = new int[n];
        int tmp;

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < i; j++)
            {
                tmp = nums1[i, j];
                nums1[i, j] = nums1[j, i];
                nums1[j, i] = tmp;
            }
        }

        for (int i = 0; i < n; i++)
        {
            tmp = 0;
            for (int j = 0; j < n; j++)
            {
                if (nums1[i, j] > pp)
                    tmp++;
            }
            mas[i] = tmp;
        }

        Console.WriteLine("Чисел, больших " + pp);
        for (int i = 0; i < n; i++)
            Console.Write(mas[i] + "\t");
    }
}
