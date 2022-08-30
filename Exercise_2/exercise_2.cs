// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

using System;
{
    Console.Write("Введите строку: ");
    int line = Convert.ToInt32(Console.ReadLine()) - 1;
    Console.Write("Введите столбец: ");
    int column = Convert.ToInt32(Console.ReadLine()) - 1;
    int n = 3; 
    int m = 4; 
    Random random = new Random();
    int[,] matrix = new int[n, m];
    Console.WriteLine("Исходный массив: ");
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = random.Next(10, 99);
            Console.Write("{0} ", matrix[i, j]);
        }
    Console.WriteLine();
    }
    if (line < 0 | line > matrix.GetLength(0) - 1 | column < 0 | column > matrix.GetLength(1) - 1)
    {
        Console.WriteLine("Элемент не существует");
    }
    else
    {
        Console.WriteLine("Значение элемента массива = {0}", matrix[line, column]);
    }
}
