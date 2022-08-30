// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

using System;
{
    double[,] matrix = new double[3, 4];
    Random random = new Random();
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            matrix[i, j] = random.Next(0, 99);
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
 
            for (int i = 0; i < 4; i++)
            {
                double summ = 0;
                for (int j = 0; j < 3; j++)
                {
                    summ = summ + matrix[j,i];
                }
                double average = summ / 3;
                int n = i + 1;
                Console.WriteLine("{0,6:F2}", average);
            }
}
