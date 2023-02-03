﻿/*Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
Например, изначально массив
 выглядел вот так:
1 4 7 2
5 9 2 3
8 4 2 4
Новый массив будет выглядеть 
вот так:
1 4 7 2
5 81 2 9
8 4 2 4*/

int GetNumber(string message)
{
    int result = 0;

    while (true)
    {
        Console.WriteLine(message);

        if (int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не корректное число. Повторите ввод.");
        }
    }

    return result;
}

int[,] InitMatrix(int rows, int columns)
{
    int[,] matrix = new int[rows, columns];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = (i + j);
        }
    }

    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} ");
        }

        Console.WriteLine();
    }
    Console.WriteLine();
}

void FindEvenIndex(int [,] matrix) // индексирование для "человека" начиная c 0
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (i % 2 == 1 && j % 2 == 1)
            matrix[i,j] = matrix [i,j] * matrix[i,j];
        }
    }
}
int countOfRows = GetNumber("Введите кол-во строк:");
int countOfColumns = GetNumber("Введите кол-во столбцов:");
int[,] matrix = InitMatrix(countOfRows, countOfColumns);

PrintMatrix(matrix);
FindEvenIndex(matrix);
PrintMatrix(matrix);