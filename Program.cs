using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks_47_50_52
{
    internal class Program
    {
        static void Main(string[] args)
        {
            void Zadacha47()
            { //Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
                // m = 3, n = 4.
                // 0,5 7 -2 -0,2
                // 1 -3,3 8 -9,9
                // 8 7,8 -7,1 9
                double[,] a = new double[3, 4];

                Random random = new Random();
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        a[i, j] = Math.Round(random.NextDouble() * 100, 2);
                        Console.Write((a[i, j] + "       "));
                    }
                    Console.WriteLine();
                }
            }

            void Zadacha47UsingMethods()
            {   //Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
                // m = 3, n = 4.
                // 0,5 7 -2 -0,2
                // 1 -3,3 8 -9,9
                // 8 7,8 -7,1 9
                Console.WriteLine("Введите количество строк массива");
                int m = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите количество столбцов массива");
                int n = Convert.ToInt32(Console.ReadLine());
                double[,] array = new double[m, n];
                Random random = new Random();
                FillArray(array);
                PrintArray(array);

                void FillArray(double[,] matrix, int startNumber = 0, int finishNumber = 0)
                {
                    int rows = array.GetLength(0);
                    int columns = array.GetLength(1);
                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < columns; j++)
                        {
                            array[i, j] = Math.Round(random.NextDouble() * 100, 2);
                        }
                    }
                }
                void PrintArray(double[,] matrix, int startNumber = 0, int finishNumber = 0)
                {
                    int rows = array.GetLength(0);
                    int columns = array.GetLength(1);
                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < columns; j++)
                        {
                            array[i, j] = Math.Round(random.NextDouble() * 100, 2);
                            Console.Write(array[i, j] + "   ");
                        }
                        Console.WriteLine();
                    }
                }
            }
            void Zadacha51()
            {
                //Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
                //и возвращает значение этого элемента или же указание, что такого элемента нет.
                // Например, задан массив:
                // 1 4 7 2
                // 5 9 2 3
                // 8 4 2 4
                // 17 -> такого числа в массиве нет

                Console.WriteLine("Введите количество строк массива");
                int m = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите количество столбцов массива");
                int n = Convert.ToInt32(Console.ReadLine());
                double[,] array = new double[m, n];
                Random random = new Random();
                FillArray(array);
                PrintArray(array);

                void FillArray(double[,] matrix, int startNumber = 0, int finishNumber = 0)
                {
                    int rows = array.GetLength(0);
                    int columns = array.GetLength(1);
                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < columns; j++)
                        {
                            array[i, j] = Math.Round(random.NextDouble() * 100, 2);
                        }
                    }
                }
                void PrintArray(double[,] matrix, int startNumber = 0, int finishNumber = 0)
                {
                    int rows = array.GetLength(0);
                    int columns = array.GetLength(1);
                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < columns; j++)
                        {
                            array[i, j] = Math.Round(random.NextDouble() * 100, 2);
                            Console.Write(array[i, j] + "   ");
                        }
                        Console.WriteLine();
                    }

                    Console.WriteLine("Введите индекс строки искомого элемента");
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите индекс столбца искомого элемента");
                    int b = Convert.ToInt32(Console.ReadLine());
                    if (a > rows && b > columns)
                        Console.WriteLine($"ТАКОГО ЧИСЛА В ЗАДАННОМ ВАМИ МАССИВЕ НЕТ");
                    else
                    {
                        object c = array.GetValue(a, b);
                        Console.WriteLine(c);
                    }
                    Console.WriteLine();
                }
            }
           
            void Zadacha52()
            {
                // Задача 52.Задайте двумерный массив из целых чисел.Найдите среднее арифметическое элементов в каждом столбце.
                //Например, задан массив:
                //1 4 7 2
                //5 9 2 3
                //8 4 2 4
                //Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.]
                Random random = new Random();
                int rows = random.Next(3, 4);
                int columns = random.Next(3, 4);
                int[,] array = new int[rows, columns];
                FillArray(array);
                PrintArray(array);
                void FillArray(int[,] ar, int startNumber = 0, int finishNumber = 10)
                {
                    finishNumber++;
                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < columns; j++)
                        {
                            array[i, j] = random.Next(startNumber, finishNumber);
                        }
                    }
                }
                void PrintArray(int[,] ar)
                {
                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < columns; j++)
                        {
                            Console.Write(array[i, j] + "   ");
                        }
                        Console.WriteLine();
                    }
                    for (int i = 0; i < rows; i++)
                    {
                        double Average = 0;
                        for (int j = 0; j < columns; j++)
                        {
                            Average += array[j, i];
                        }
                        Console.Write($"\nCреднее арифметическое:");
                        Average = Math.Round(Average / columns, 1);
                        Console.WriteLine($"столбца № {i + 1} {"="} {Average}");

                    }
                 
                }
            }
            //Zadacha47();
            //Zadacha47UsingMethods();
            //Zadacha51();
            //Zadacha52();
           
        }
    }
}
   
