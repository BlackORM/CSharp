//
Console.Clear();
int userNumber = InputNumber("Введите целое положительное число: ", "Ошибка ввода данных!");
int resultToBin = ConvertToBin(userNumber);
Console.WriteLine($"{userNumber} = {resultToBin}");

int ConvertToBin(int num)
{
    int result = 1;
       while (num >= 1)
    {
        int ost = num % 2;
        num /= 2;
        result = result * 10 + ost;
    }
return result /10;
}

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
