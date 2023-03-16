// Двумерный массив заполненный случайными целыми

Console.Clear();
Console.Write("Введите количество строк массива: ")
int row = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите количество столбцов массива: ")
int col = int.Parse(Console.ReadLine() ?? "");

int[,] array = GetArray(row, col, -10, 10);
PrintArray(array);


Console.WriteLine($"В массиве [{string.Join(" ,", userNumbers)}] положительных чисел {positiveNumbers}");

int[] GetArray(int m, int n, int minValue, int maxValue)
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
    for (int i = 0; i < GetArray(0); i++)
    {
        for (int j = 0; j < GetArray(1); j++)
        {
            Console.Write($"{inArray[i, j]} ")
        }
        Console.WriteLine();
    }

}