// Создаем массив рандомных вещественных элементов 
// и ищем разницу между минимальным и максимальным
Console.Clear();
int num = InputNumber("Введите длинну массива: ", "Ошибка ввода данных!");
//запрашиваем количество цифр после запятой
int col = InputNumber("Введите число цифр после запятой: ", "Ошибка ввода данных!");
//ограничиваем количество знаков после запятой до максимума типа
if (col > 15) col = 15;
double[] array = GetArray(num, col);
double arrMin = FindMin(array);
double arrMax = FindMax(array);
double diff = arrMax - arrMin;

Console.WriteLine($"Разница между мин элементом {arrMin} и макс элементом {arrMax} массива [{string.Join(" ,", array)}] = {diff}");


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
//заполнение массива вещественными числами
double[] GetArray(int size, int digit)
{
    double[] res = new double[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = Math.Round(new Random().NextDouble(), digit);
    }
    return res;
}
//поиск минимального элемента
double FindMin(double[] arr)
{
    double min = arr[0];
    foreach (double item in arr)
    {
        if (item < min) min = item;
    }
    return min;
}
//поиск максимального элемента
double FindMax(double[] arr)
{
    double max = arr[0];
    foreach (double item in arr)
    {
        if (item > max) max = item;
    }
    return max;
}

