// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.Clear();
int row = InputPositiveNumber("Введите количество строк массива: ", "Ошибка ввода данных!");
int col = InputPositiveNumber("Введите количество столбцов массива: ", "Ошибка ввода данных!");
int digits = InputPositiveNumber("Введите сколько знаков после запятой выводить: ", "Ошибка ввода данных!");

// Заполняем массив числами от 1 до 9
int[,] array = GetArray(row, col, 1, 9);

// Выводим массив
PrintArray(array);

// Считаем среднее в столбце
double[] sum = AverageCol(array);

// Выводим
Console.WriteLine();
Console.WriteLine($"Среднее арифметическое каждого столбца: ");
PrintRoundArray(sum, digits);

// ввод и проверка ввода положительных чисел для строк и столбцов
int InputPositiveNumber(string message, string errormessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect && userNumber > 0)
            return userNumber;
        Console.WriteLine(errormessage);
    }
}

// генерация массива
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

// вывод массива
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

// считаем среднее арифметическое в столбце
double[] AverageCol(int[,] array)
{
    double[] sumCol = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sumCol[j] += array[i, j] ;
        }
        sumCol[j] /= array.GetLength(0);
    }
    return sumCol;
}

//выводим с округлением
void PrintRoundArray(double[] inArray, int digits)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        Console.Write($"{Math.Round(inArray[i], digits)}; ");
    }
}
