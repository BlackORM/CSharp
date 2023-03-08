// Считаем сумму цифр в числе
Console.Clear();
//Ввод числа с проверкой
int num = GetNumberFromUser("Введите целое число и увидите сумму его цифр: ", "Ошибка ввода!");
//Вызов метода подсчета суммы цифр
int sumDigit = CountSum(num);
//Вывод ответа
Console.WriteLine($"Сумма цифра в числе {num} = {sumDigit}");

int CountSum(int num)
{
    if (num == 0) return 0;
    if (num < 0) num = num * -1;
    int sum = 0;
    while (num != 0)
    {
        sum = sum + num % 10;
        num = num / 10;
    }
    return sum;
}

int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}