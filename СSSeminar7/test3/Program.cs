// В двумерном массиве элементы с нечетными индексами возводим в квадрат

Console.Clear();
Console.Write("Введите количество строк массива: ");
int row = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите количество столбцов массива: ");
int col = int.Parse(Console.ReadLine() ?? "");

int[,] array = GetArray(row, col);
PrintArray(array);
int[,] newArray = SquareOdd(array);
Console.WriteLine();
PrintArray(newArray);


int[,] SquareOdd(int[,] inArray)
{
    int[,] arr = new int[inArray.GetLength(0),inArray.GetLength(1)];
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            if (i % 2 != 0 && j % 2 != 0) arr[i, j] = (int)Math.Pow(inArray[i, j], 2);
            else
            {
                arr[i, j] = inArray[i, j];
            }
        }
    }
    return arr;
}

int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];

    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(1, 10);
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
