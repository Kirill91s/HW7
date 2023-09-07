﻿// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


// void Main()
// {
//     double[,] matrix = FillMatrix(3, 4, -10, 10);
//     PrintMatrix(matrix);
// }


// double[,] FillMatrix(int row, int col, int beginRange, int endRange)
// {
//     double[,] matrix = new double[row, col];
//     Random rand = new Random();
//     for (int i = 0; i < row; i++)
//     {
//         for (int j = 0; j < col; j++)
//         {
//             matrix[i, j] = Math.Round(rand.Next(beginRange, endRange + 1) + rand.NextDouble(), 1);
//         }
//     }
//     return matrix;
// }


// void PrintMatrix(double[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             System.Console.Write(matrix[i, j] + "\t");
//         }
//         System.Console.WriteLine();
//     }
// }


// Main();





﻿// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет


// void Main()
// {
//     int[,] matrix = FillMatrix(3, 4, -100, 100);
//     PrintMatrix(matrix);
//     ElementSearch(matrix);
// }


// int ReadInt(string text)
// {
//     System.Console.WriteLine(text);
//     return Convert.ToInt32(Console.ReadLine());
// }


// int[,] FillMatrix(int row, int col, int beginRange, int endRange)
// {
//     int[,] matrix = new int[row, col];
//     Random rand = new Random();
//     for (int i = 0; i < row; i++)
//     {
//         for (int j = 0; j < col; j++)
//         {
//             matrix[i, j] = rand.Next(beginRange, endRange + 1);
//         }
//     }
//     return matrix;
// }


// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             System.Console.Write(matrix[i, j] + "\t");
//         }
//         System.Console.WriteLine();
//     }
// }


// void ElementSearch(int[,] matrix)
// {
//     int row = ReadInt("Введите номер строки матрицы: ");
//     int col = ReadInt("Введите номер столбца матрицы: ");
//     if (row <= matrix.GetLength(0) && col <= matrix.GetLength(1))
//     {
//         System.Console.WriteLine($"Значение элемента матрицы согласно введённым данным: {matrix[row, col]} ");
//     }
//     else
//     {
//         System.Console.WriteLine($"Элемента с таким адресом в матрице не существует.");
//     }
// }


// Main();



﻿// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.


// void Main()
// {
//     int[,] matrix = FillMatrix(4, 5, -100, 100);
//     PrintMatrix(matrix);
//     double[] array = AverageCol(matrix);
//     PrintArray(array);
// }


// int[,] FillMatrix(int row, int col, int beginRange, int endRange)
// {
//     int[,] matrix = new int[row, col];
//     Random rand = new Random();
//     for (int i = 0; i < row; i++)
//     {
//         for (int j = 0; j < col; j++)
//         {
//             matrix[i, j] = rand.Next(beginRange, endRange + 1);
//         }
//     }
//     return matrix;
// }


// void PrintMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             System.Console.Write(matrix[i, j] + "\t");
//         }
//         System.Console.WriteLine();
//     }
// }


// double[] AverageCol(int[,] matrix)
// {
//     double[] answer = new double[matrix.GetLength(1)];
//     for (int j = 0; j < matrix.GetLength(1); j++)
//     {
//         for (int i = 0; i < matrix.GetLength(0); i++)
//         {
//             answer[j] += matrix[i, j];
//         }
//         answer[j] /= matrix.GetLength(0);;
//     }
//     return answer;
// }


// void PrintArray(double[] array)
// {
//     System.Console.WriteLine($"Среднее арифметическое значение каждого столбца матрицы: [ {string.Join(", ", array)} ]");
// }


// Main();
