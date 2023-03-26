// Сумма цифр введенного числа через рекурсию
Console.Clear();

int number = InputNumber("Введите число: ", "Ошибка ввода данных!");
int result = SumDigits(number);
Console.WriteLine($"Сумма цифр числа {number} = {Math.Abs(result)}");

int SumDigits(int m)
{
    if (m == 0) return 0;
    return SumDigits(m / 10) + m % 10;
}

//ввод и проверка ввода любых чисел
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

