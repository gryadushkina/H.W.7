/*Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение
 этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

using System;
using static System.Console;
Clear();
Write("Введите количество строк массива: ");
int rows=int.Parse(ReadLine());
Write("Введите количество столбцов массива: ");
int columns=int.Parse(ReadLine());
int[,] array = GetArray(rows, columns, 0, 10);
Write("Введите строку элемента: ");
int a =int.Parse(ReadLine());
Write("Введите столбец элемента: ");
int b = int.Parse(ReadLine());
PrintArray(array);
ShowPosition(array, a, b);

 bool ShowPosition(int[,] array2, int c, int d)
{
    bool result = true;
    if (c < array2.GetLength(0) && d < array2.GetLength(1))
    Write($"заданный эл-т - {array2[c, d]}");
    else 
    Write("Такого эл-та не существует");
    return result;
}


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