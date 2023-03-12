// Создаем рандомный массив и определяем сколько элементов попадает в отрезок [10, 99]
Console.Clear();
int num = InputNumber("Введите длинну массива: ", "Ошибка ввода данных!");
int[] array = GetArray(num, 0, 199);
Console.WriteLine(string.Join(" ,", array));
int CountElements = Count(array);
Console.WriteLine($"Количество элементов из отрезка 10-99 = {CountElements}");




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

int Count(int[] arr)
{
    int count = 0;
    foreach (int item in arr)
    {
        if (item >= 10 && item < 100) count += 1;
    }
    return count;
}