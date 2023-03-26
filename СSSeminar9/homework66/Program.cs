// Сумма натуральных чисел между двумя заданными (через рекурсию)

Console.Clear();

int M = InputNumber("Введите первое число: ", "Ошибка ввода данных!");
int N = InputNumber("Введите второе число: ", "Ошибка ввода данных!");

if (M > N)
{
    int temp = M;
    M = N;
    N = temp;
}

int result = SumFromMtoN(M, N);
Console.WriteLine($"Сумма чисел между {M} и {N}: {result}");

int SumFromMtoN(int m, int n)
{
    if (m == n) return m;
    return m + SumFromMtoN(m + 1, n);
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
