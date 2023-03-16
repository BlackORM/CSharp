//
Console.Clear();
int a = InputNumber("Введите первую сторону треугольника: ", "Ошибка ввода данных!");
int b = InputNumber("Введите первую сторону треугольника: ", "Ошибка ввода данных!");
int c = InputNumber("Введите первую сторону треугольника: ", "Ошибка ввода данных!");
bool isTriangle = IsTriangle(a, b, c);
Console.WriteLine(isTriangle? "да":"нет");




int InputNumber(string message, string errormessage)
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

bool IsTriangle(int a, int b, int c)
{
    if (a + b > c && a + c > b && b + c > a)
    {
        return true;
    }
    else return false;
}
