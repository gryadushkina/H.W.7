/*Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/



using System;
using static System.Console;
Clear();
Write("Введите количество строк в массиве: ");
int rows = int.Parse(Console.ReadLine());
Write("Введите количество столбцов в массиве: ");
int columns = int.Parse(Console.ReadLine());
int[,] Array = GetArray(rows, columns, 0, 10);
PrintArray(Array);
arif(Array);


int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}


void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i,j]} ");
        }
        WriteLine();
    }
}


void arif(int[,] array2)
{
double[] sum = new double[array2.GetLength(1)];
for (int i = 0; i < array2.GetLength(1); i++)
{
    for (int j = 0; j < array2.GetLength(0); j++)
    {
        sum[i] = sum[i] + array2[i,j];
    }
    sum[i] = sum[i] / array2.GetLength(0);
}
for(int i = 0; i < sum.Length; i++)
{
    WriteLine($"среднее арифметическое {i + 1} колонны = {sum[i]:F2}"); 
}
}

