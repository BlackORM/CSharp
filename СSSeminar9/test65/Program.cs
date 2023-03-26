// Вывод всех натуральных чисел между двумя заданными (через рекурсию)

Console.Clear();

int M = InputNumber("Введите первое число: ", "Ошибка ввода данных!");
int N = InputNumber("Введите второе число: ", "Ошибка ввода данных!");

if (M > N)
{
    int temp = M;
    M = N;
    N = temp;
}

string result = NumbersFromMtoN(M, N);
Console.WriteLine($"Натуральные числа от {M} до {N}: {result}");

string NumbersFromMtoN(int m, int n)
{
    if (m == n)
        return m.ToString();
    else return m + ", " + NumbersFromMtoN(m + 1, n);
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
