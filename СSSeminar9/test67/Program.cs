// Сумма цифр введенного числа через рекурсию
Console.Clear();

int number = InputPositiveNumber("Введите первое число: ", "Ошибка ввода данных!");
int result = SumDigits(number);
Console.WriteLine($"Сумма цифр числа {number} = {result}");



int SumDigits(int m)
{
    if (m == 0) return 0;
    return SumDigits(m / 10) + m % 10;
}

//ввод и проверка ввода положительных чисел для строк и столбцов
int InputPositiveNumber(string message, string errormessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect && userNumber > 0)
            return userNumber;
        Console.WriteLine(errormessage);
    }
}

