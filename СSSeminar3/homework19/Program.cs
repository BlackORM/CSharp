// Определяем является ли пятизначное число палиндромом
Console.Clear();

//Вводим число с проверкой ввода
int userNum = num("Введите пятизначное число и узнайте является ли оно палиндромом: ");

//Проверяем пятизначное ли оно
if (userNum < 1000 || userNum > 99999)
{
    Console.WriteLine($"Ваше число {userNum} не пятизначное!");
}

//Если пятизначное сравниваем 1 и 5 цифры, если равны то сравниваем 2 и 4 цифру
else
{
    if (userNum / 10000 != userNum % 10)
    {
        Console.WriteLine($"Ваше число {userNum} не палиндром!");
    }
    else if (userNum / 1000 % 10 != userNum / 10 % 10)
    {
        Console.WriteLine($"Ваше число {userNum} не палиндром!");
    }
    else Console.WriteLine($"Ваше число {userNum} палиндром!");
}

//проверка ввода
static int num(string message)
{
    while (true)
    {
        try
        {
            Console.WriteLine(message);
            return (int.Parse(Console.ReadLine() ?? ""));
        }
        catch (Exception exc)
        {
            Console.WriteLine($"Ошибка ввода данных! {exc.Message}");

        }
    }
}