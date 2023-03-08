// Вводим два числа и возводим первое в степень второго
Console.Clear();
//Ввод чисел с проверкой
Console.WriteLine("Введите два числа и мы возведем первое в степень второго");
int num1 = GetNumberFromUser("Введите целое число: ", "Ошибка ввода!");
int num2 = GetNumberFromUser("Введите степень числа: ", "Ошибка ввода!");
//Вызов метода возведения в степень
int powResult = CountPow(num1, num2);
//Вывод ответа
Console.WriteLine($"Число {num1} в степени {num2} = {powResult}");

int CountPow(int num1, int num2)
{
    if (num1 == 0 || num1 == 0) return 1;
    int pow = num1;
    for (count = 1; count < num2; count++)
    {
        pow = pow * num1;
    }
    return pow;
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