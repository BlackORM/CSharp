// Возведение А в степень В через рекурсию

Console.Clear();

int A = InputNumber("Введите число: ", "Ошибка ввода данных!");
int B = InputPositiveNumber("Введите степень числа: ", "Ошибка ввода данных!");

int result = PowAtoB(A, B);
Console.WriteLine($"Число {A} в степени {B} = {result}");

int PowAtoB(int a, int b)
{
    if (b == 0) return 1;
    return a * PowAtoB(a, b-1);
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
