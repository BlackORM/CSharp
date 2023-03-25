// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

Console.WriteLine();
int row = InputPositiveNumber("Введите первую размерность массива: ", "Ошибка ввода данных!");
int col = InputPositiveNumber("Введите вторую размерность массива: ", "Ошибка ввода данных!");
int sheet = InputPositiveNumber("Введите третью размерность массива: ", "Ошибка ввода данных!");

int numElements = row * col * sheet;

int minValue = Input2DigitNumber("Введите начало диапазона случайных двузначных чисел: ", "Ошибка ввода данных!");
int maxValue = Input2DigitNumber("Введите конец диапазона случайных двузначных чисел: ", "Ошибка ввода данных!");

if (maxValue - minValue + 1 < numElements)
{
    Console.WriteLine("Количество неповторяющихся элементов меньше размерности массива!");
    return;
}

// создаем одномерный массив размерности трехмерного и заполняем неповторяющимися значениями
int[] nonRepeatElements = new int[numElements];
Get2DigitArray(nonRepeatElements, minValue, maxValue);

// создаем трехмерный массив и заполняем уже сгенерированными ранее числами
int[,,] finalArray = Get3DigitArray(row, col, sheet, nonRepeatElements);

PrintFinalArray(finalArray);

//---------------------МЕТОДЫ------------------------------//
// переносим неповторяющиеся числа в трехмерную матрицу
int[,,] Get3DigitArray(int row, int col, int sh, int[] inArray)
{
    int[,,] array = new int[row, col, sh];
    int count = 0;

    for (int i = 0; i < row; i++)
    {
        for (int j = 0; j < col; j++)
        {
            for (int k = 0; k < sh; k++)
            {
                array[i, j, k] = inArray[count];
                count++;
            }
        }
    }
    return array;
}

// генерация массива неповторяющихся двузначных чисел
void Get2DigitArray(int[] resultArray, int minValue, int maxValue)
{
    int temp;
    for (int i = 0; i < resultArray.Length; i++)
    {
        resultArray[i] = new Random().Next(minValue, maxValue + 1);
        temp = resultArray[i];
        if (i > 0)
        {
            for (int j = 0; j < i; j++)
            {
                while (resultArray[i] == resultArray[j])
                {
                    resultArray[i] = new Random().Next(minValue, maxValue + 1);
                    j = 0;
                    temp = resultArray[i];
                }
                temp = resultArray[i];
            }
        }
    }
}

// ввод и проверка ввода положительных чисел для размерностей массива
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

// ввод и проверка двузначных чисел
int Input2DigitNumber(string message, string errormessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect && userNumber > 9 && userNumber < 100)
            return userNumber;
        Console.WriteLine(errormessage);
    }
}

// вывод трехмерного массива с координатами
void PrintFinalArray(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            for (int k = 0; k < inArray.GetLength(2); k++)
            {
                Console.Write($"{inArray[i, j, k]}({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}

