// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
Console.Clear();
int userCount = InputNumber("Введите сколько чисел хотите ввести: ", "Ошибка ввода данных!");
int[] userNumbers = new int[userCount];
int countPositive = 0;
for (int i = 0; i < userCount; i++)
{
    userNumbers[i] = InputNumber("Введите целое число: ", "Ошибка ввода данных!");
    if (userNumbers[i]>0) countPositive ++;
}

Console.WriteLine($"В массиве [{string.Join(" ,", userNumbers)}] положительных чисел {countPositive}");

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
