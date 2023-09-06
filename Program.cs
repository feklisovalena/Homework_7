// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9




// Console.WriteLine("Первая размерность массив");
// int rows = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Вторая размерность массив");
// int colums = Convert.ToInt32(Console.ReadLine()); 

// double[,] numbers = new double[rows, colums];
// FillArray2D(numbers);
// PrintArray2D(numbers);

// void FillArray2D(double[,] array)
// {
//     for (int i=0; i<array.GetLength(0); i++)
//     {
//         for (int j=0; j<array.GetLength(0); j++)
//         {
//             array[i,j]= new Random().Next(-10, 10)/10.0;
//         }
//     }
// }

// void PrintArray2D(double[,] array)
// {
//     for (int i=0; i<array.GetLength(0); i++)
//     {
//         for (int j=0; j<array.GetLength(0); j++)
//         {
//             Console.Write(array[i,j] + " ");
//         }
//         Console.WriteLine();
//     }
//     Console.WriteLine();
// }







// Задача 50. Напишите программу, которая на вход 
// принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет




// int rows = ReadInt("Введите индекс строки: ");
// int colums = ReadInt("Введите индекс столбца: ");
// int[,] numbers = new int[6, 8];
// FillArray2D(numbers);
// PrintArray2D(numbers);
// if (rows < numbers.GetLength(0) && colums < numbers.GetLength(1)) Console.WriteLine(numbers[rows, colums]);
// else Console.WriteLine($"{rows}{colums} -> такого числа в массиве нет");

// void FillArray2D(int[,] array)
// {
// for (int i = 0; i < array.GetLength(0); i++)
// {
// for (int j = 0; j < array.GetLength(1); j++)
// {
//             array[i, j] = new Random().Next(1, 10);
// }
// }
// }

// void PrintArray2D(int[,] array)
// {
// for (int i = 0; i < array.GetLength(0); i++)
// {
// for (int j = 0; j < array.GetLength(1); j++)
// {
//             Console.Write(array[i, j] + " ");
// }
//         Console.WriteLine();
// }
//     Console.WriteLine();
// }

// int ReadInt(string message)
// {
//     Console.Write(message);
// return Convert.ToInt32(Console.ReadLine());
// }







// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.




// Console.Write("Введите размерность m массива: ");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите размерность n массива: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int[,] randomArray = new int[m,n];

// void mas(int m, int n)
// {
// int i,j;
// Random rand = new Random();
// for (i = 0; i < m; i++)
// {
// Console.WriteLine();
// for (j = 0; j < n; j++)
// {
// randomArray[i,j] = rand.Next(1,9);
// Console.Write($"{randomArray[i,j]} ");
// }
// Console.WriteLine();
// }
// }

// void arif(int m, int n)
// {
// Console.Write("Среднее арифметическое каждого столбца: ");
// int i,j;
// Random rand = new Random();
// for (j = 0; j < n; j++)
// {
// double sum = 0;
// for (i = 0; i < m; i++)
// {
// sum = sum + randomArray[i,j];
// }
// Console.Write($"{sum/(i):F1}; ");
// }
// }
// mas(m,n);
// arif(m,n);