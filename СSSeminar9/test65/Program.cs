// Вывод всех натуральных чисел между двумя заданными (через рекурсию)

Console.Clear();

int M = InputPositiveNumber("Введите первое число: ", "Ошибка ввода данных!");
int N = InputPositiveNumber("Введите второе число: ", "Ошибка ввода данных!");


string result = NumbersFromMtoN(M, N);

Console.WriteLine($"Натуральные числа от M={M} до N={N}: {result}");


string NumbersFromMtoN(int m, int n)
{
    if (m == n)
        return m.ToString();
    else return m + ", " + NumbersFromMtoN(m + 1, n);
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

