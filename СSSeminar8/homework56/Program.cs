// Задайте прямоугольный двумерный массив. Напишите программу, которая будет 
// находить строку с наименьшей суммой элементов.

Console.WriteLine();
int row = InputPositiveNumber("Введите количество строк массива: ", "Ошибка ввода данных!");
int col = InputPositiveNumber("Введите количество столбцов массива: ", "Ошибка ввода данных!");
int minValue = InputNumber("Введите начало диапазона случайных чисел: ", "Ошибка ввода данных!");
int maxValue = InputNumber("Введите конец диапазона случайных чисел: ", "Ошибка ввода данных!");

//создаем массив
int[,] array = GetArray(row, col, minValue, maxValue);
PrintArray(array);
Console.WriteLine();
int index = RowMinSum(array);

Console.WriteLine($"Минимальная сумма элементов в строке номер {index + 1}");

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

// Находим сумму по строкам и индекс строки с минимальной суммой
int RowMinSum(int[,] inArray)
{
    int indexMin = 0;
    int sumRow = 0;
    // ищем сумму в первой строке и присваиваем минимуму
    for (int j = 0; j < inArray.GetLength(1); j++)
    {
        sumRow += inArray[0, j];
    }
    int sumMin = sumRow;
    //Console.WriteLine(sumMin);
    for (int i = 1; i < inArray.GetLength(0); i++)
    {
        sumRow = 0;
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            sumRow += inArray[i, j];
        }

        if (sumMin > sumRow)
        {
            sumMin = sumRow;
            indexMin = i;
            //Console.WriteLine(sumMin);
        }
        //else Console.WriteLine(sumRow);
    }
    return indexMin;
}

