//
Console.Clear();
int num = InputNumber("Введите число для перевода в двоичную систему: ", "Ошибка ввода данных!");



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

void ReversArray(int[] arr)
{
    int result[] = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        result[i] = arr[arr.Length - i - 1];
    }
    return result;
}

void ReversArray2(int[] arr)
{
    for (int i = 0; i < arr.Length / 2; i++)
    {
        int a = arr[i];
        arr[i] = arr[arr.Length - i - 1];
        arr[arr.Length - i - 1] = a;
    }
}



