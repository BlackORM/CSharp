// Создаем массив рандомных элементов и определяем есть ли в нем заданное число
Console.Clear();
int num = InputNumber("Введите длинну массива: ", "Ошибка ввода данных!");
int minValue = InputNumber("Введите минимальный элемент массива: ", "Ошибка ввода данных!");
int maxValue = InputNumber("Введите максимальный элемент массива: ", "Ошибка ввода данных!");
int numfind = InputNumber("Введите какое число ищем в массиве: ", "Ошибка ввода данных!");
int[] array = GetArray(num, minValue, maxValue);
Console.Write($"Сгенерировался массив чиcел {minValue} от до {maxValue}: ");
Console.WriteLine(string.Join(", ", array));
bool res = Find(array, numfind);

if (res == true)
{
    Console.WriteLine($"В данном массиве есть число {numfind}!");
}
else
{
    Console.WriteLine($"В данном массиве нет числа {numfind}!");
}

static int InputNumber(string message, string errormessage)
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

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

bool Find(int[] arr, int x)
{
    foreach (int el in arr)
    {
        if (el == x)
        {
            return true;
            break;
        }
    }
    return false;
}