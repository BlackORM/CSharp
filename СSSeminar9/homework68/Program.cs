// Вычисление функции Аккермана с помощью рекурсии
Console.Clear();

int M = InputPositiveNumber("Введите первое число: ", "Ошибка ввода данных!");
int N = InputPositiveNumber("Введите второе число: ", "Ошибка ввода данных!");

int result = Ackermann(M, N);
Console.WriteLine($"Функция Аккермана: m = {M}, n = {N} => A(m,n) = {result}");

// Функция Аккермана
int Ackermann(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return Ackermann(m - 1, 1);
    else return Ackermann(m - 1, Ackermann(m, n - 1));
}

//ввод и проверка ввода положительных чисел для строк и столбцов
int InputPositiveNumber(string message, string errormessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect && userNumber >= 0)
            return userNumber;
        Console.WriteLine(errormessage);
    }
}
