// Количество четных чисел в рандомном массиве из 3-значных чисел
Console.Clear();
int num = InputNumber("Введите длинну массива: ", "Ошибка ввода данных!");
int[] array = GetArray(num, 100, 999);
Console.WriteLine(string.Join(" ,", array));
int result = CountEven(array);
Console.WriteLine($"В массиве [{string.Join(" ,", array)}] четных чисел {result}");

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

int CountEven(int[] arr)
{
    int count = 0;
    foreach (int item in arr)
    {
        if (item % 2 == 0) count++;
    }
    return count;
}
