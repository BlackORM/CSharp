// Создаем массив рандомных вещественных элементов 
// и ищем разницу между минимальным и максимальным
Console.Clear();
int num = InputNumber("Введите длинну массива: ", "Ошибка ввода данных!");
int col = InputNumber("Введите число цифр после запятой: ", "Ошибка ввода данных!");
double[] array = GetArray(num, col);
double arrMin = FindMin(array);
double arrMax = FindMax(array);
double diff = arrMax - arrMin;

Console.WriteLine($"Разница между мин элементом {arrMin} и макс элементом {arrMax} массива [{string.Join(" ,", array)}] = {diff}");


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
//
double[] GetArray(int size, int digit)
{
    double[] res = new double[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = Math.Round(new Random().NextDouble(), digit);
    }
    return res;
}

double FindMin(double[] arr)
{
    double min = arr[0];
    foreach (double item in arr)
    {
                if (item < min) min = item;
    }
    return min;
}

double FindMax(double[] arr)
{
    double max = arr[0];
    foreach (double item in arr)
    {
                if (item > max) max = item;
    }
    return max;
}

