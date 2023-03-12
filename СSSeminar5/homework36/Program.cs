// Создаем массив рандомных элементов и ищем сумму элементов на нечетных позициях
Console.Clear();
int num = InputNumber("Введите длинну массива: ", "Ошибка ввода данных!");
int minValue = InputNumber("Введите минимальный элемент массива: ", "Ошибка ввода данных!");
int maxValue = InputNumber("Введите максимальный элемент массива: ", "Ошибка ввода данных!");
int[] array = GetArray(num, minValue, maxValue);
int result = SumOddElements(array);
Console.WriteLine($"Сумма элементов на нечетных позициях массива [{string.Join(" ,", array)}] = {result}");

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

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}
//Метод считающий сумму элементов на нечетных позициях
int SumOddElements(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i+=2)
    {
        sum += arr[i]; 
    }
    return sum;
}

