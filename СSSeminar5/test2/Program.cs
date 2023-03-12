// Создаем массив рандомных элементов и меняем + на - и наоборот
Console.Clear();
int num = InputNumber("Введите длинну массива: ", "Ошибка ввода данных!");
int minValue = InputNumber("Введите минимальный элемент массива: ", "Ошибка ввода данных!");
int maxValue = InputNumber("Введите максимальный элемент массива: ", "Ошибка ввода данных!");
int[] array = GetArray(num, minValue, maxValue);
Console.WriteLine(string.Join(" ,", array));
Change(array);
Console.WriteLine(string.Join(" ,", array));

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

void Change(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] *= -1;
    }
}
