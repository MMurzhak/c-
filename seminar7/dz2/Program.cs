﻿/*Задача 50: Напишите программу, которая на вход
принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента
или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет*/

Console.Clear();

Console.Write("Введите количество строк массива: ");
int rows = int.Parse(Console.ReadLine() ?? "");

Console.Write("Введите количество столбцов массива: ");
int columns = int.Parse(Console.ReadLine() ?? "");

int[,] array = GetArray(rows, columns, 0, 10);
PrintArray(array);
CheckNum(array);


int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m,n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            while(true)
        {
            Console.Write($"Введите  {i} {j}-й элемент массива: ");
            bool isCorrect = int.TryParse(Console.ReadLine(), out int num);
            if(isCorrect)
            {
                result[i,j] = num;
                break;
            }
            else Console.WriteLine("Ошибка ввода! ");
        }
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for(int i = 0; i < inArray.GetLength(0); i++)
    {
        for(int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i,j]} ");
        }
        Console.WriteLine();
    }
}

void CheckNum(int[,] inArray)
{
    Console.Write("Введите число : ");
    int num = int.Parse(Console.ReadLine() ?? "");
    
    for(int i = 0; i < inArray.GetLength(0); i++)
    {
        for(int j = 0; j < inArray.GetLength(1); j++)
        {
            if(i == num && j == num) Console.WriteLine("Такое число имеется в массиве");
            else Console.WriteLine("Такого числа нет");
            break;
        }
        break;
    }
    
}


