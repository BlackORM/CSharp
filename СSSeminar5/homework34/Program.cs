// Количество четных чисел в рандомном массиве из 3-значных чисел
Console.Clear();
//Вводим длину массива
int num = InputNumber("Введите длину массива: ", "Ошибка ввода данных!");
//Заполняем рандомно трехзначными
int[] array = GetArray(num, 100, 999);
//Запускаем метод подсчета четных чисел
int result = CountEven(array);
//Вывод на экран
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
//Метод подсчета четных чисел 
int CountEven(int[] arr)
{
    int count = 0;
    foreach (int item in arr)
    {
        if (item % 2 == 0) count++;
    }
    return count;
}
