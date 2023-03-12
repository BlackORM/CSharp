//Призведение пар чисел в одномерном массиве
Console.Clear();
int num = InputNumber("Введите длинну массива: ", "Ошибка ввода данных!");
int[] array = GetArray(num, 1, 9);
Console.WriteLine(string.Join(" ,", array));

int newArrayLength = 0;
if (array.Length % 2 == 0)
{
    newArrayLength = array.Length / 2;
}
else
{
    newArrayLength = array.Length / 2 + 1;
}

int[] newArray = new int[newArrayLength];

SumPairs(array);
if (array.Length % 2 != 0) newArray[newArrayLength - 1] = array[newArrayLength - 1];
Console.WriteLine(string.Join(" ,", newArray));

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

int[] SumPairs(int[] arr)
{
    for (int i = 0; i < newArrayLength; i++)
    {
        newArray[i] = arr[i] * arr[arr.Length - i - 1];
    }
    return newArray;
}


