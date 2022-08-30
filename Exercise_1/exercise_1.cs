// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

using System;
{
    double[,] matrix = new double[3, 4];
    Random random = new Random();
    for (int i = 0; i < 3; i++)
    {
        for (int j = 0; j < 4; j++)
        {
            matrix[i, j] = random.Next(-50, 50) + random.NextDouble();
            Console.Write("{0,6:F1}", matrix[i, j]);
            Console.Write(" ");
        }
    Console.WriteLine();
    }
}