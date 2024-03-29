﻿// Двумерный массив заполненный числами А(m,n)=m+n

Console.Clear();
Console.Write("Введите количество строк массива: ");
int row = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите количество столбцов массива: ");
int col = int.Parse(Console.ReadLine() ?? "");

int[,] array = GetArray(row, col);
PrintArray(array);


int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = i+j;
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
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }

}