// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1,7 -> такого числа в массиве нет

Console.Clear();
int row = InputPositiveNumber("Введите количество строк массива: ", "Ошибка ввода данных!");
int col = InputPositiveNumber("Введите количество столбцов массива: ", "Ошибка ввода данных!");
int minValue = InputNumber("Введите начало диапазона случайных чисел: ", "Ошибка ввода данных!");
int maxValue = InputNumber("Введите конец диапазона случайных чисел: ", "Ошибка ввода данных!");

//создаем массив
int[,] array = GetArray(row, col, minValue, maxValue);

//вводим индексы элемента
int userRow = InputPositiveNumber("Введите номер строки: ", "Ошибка ввода данных!");
int userCol = InputPositiveNumber("Введите номер столбца: ", "Ошибка ввода данных!");

//проверяем на существование и выводим
if (userRow > array.GetLength(0) || userCol > array.GetLength(1))
{
    Console.WriteLine("Нет такой позиции в массиве");
}
else
{
    Console.WriteLine("В массиве:");
    PrintArray(array);
    Console.WriteLine($"Элемент на позиции [{userRow},{userCol}] = {array[userRow - 1, userCol - 1]}");
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
