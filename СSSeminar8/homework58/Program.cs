// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

Console.WriteLine();
int row1 = InputPositiveNumber("Введите количество строк первой матрицы: ", "Ошибка ввода данных!");
int col1 = InputPositiveNumber("Введите количество столбцов первой матрицы: ", "Ошибка ввода данных!");
int minValue1 = InputNumber("Введите начало диапазона случайных чисел: ", "Ошибка ввода данных!");
int maxValue1 = InputNumber("Введите конец диапазона случайных чисел: ", "Ошибка ввода данных!");

// Принудительно приравниваем количество строк матрицы2 количеству стобцов матрицы1
int row2 = col1;
int col2 = InputPositiveNumber("Введите количество столбцов второй матрицы: ", "Ошибка ввода данных!");
int minValue2 = InputNumber("Введите начало диапазона случайных чисел: ", "Ошибка ввода данных!");
int maxValue2 = InputNumber("Введите конец диапазона случайных чисел: ", "Ошибка ввода данных!");

//создаем первую матрицу
int[,] array1 = GetArray(row1, col1, minValue1, maxValue1);

//создаем вторую матрицу
int[,] array2 = GetArray(row2, col2, minValue2, maxValue2);

PrintArray(array1);
Console.WriteLine();
PrintArray(array2);
Console.WriteLine();
int[,] multiArray = GetMultArrays(array1, array2);

PrintArray(multiArray);

// метод перемножения матриц
int[,] GetMultArrays(int[,] arr1, int[,] arr2)
{
    int[,] multArray = new int[arr1.GetLength(0), arr2.GetLength(1)];
    for (int i = 0; i < multArray.GetLength(0); i++)
    {
        for (int j = 0; j < multArray.GetLength(1); j++)
        {
            for (int k = 0; k < arr1.GetLength(1); k++)
            {
                multArray[i, j] += arr1[i, k] * arr2[k, j];
            }
        }
    }
    return multArray;
}

//ввод и проверка ввода любых чисел
int InputNumber(string message, string errormessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errormessage);
    }
}

//ввод и проверка ввода положительных чисел для строк и столбцов
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

//генерация массива
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

//вывод массива
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


