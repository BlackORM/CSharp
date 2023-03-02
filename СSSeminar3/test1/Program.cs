// Вводим номер сектора и получаем диапозон координат
Console.Clear();

int userNumber = 0;

getNumber(ref userNumber);
findCoord(ref userNumber);

static void getNumber(ref int userNumber)
{
    while (true)
    {
        Console.Write("Введите порядковый номер четверти координат: ");
        if (int.TryParse(Console.ReadLine(), out userNumber))
            break;
        Console.WriteLine("Ошибка ввода!");
    }
}

static void findCoord(ref int userNumber)
{
    if ((userNumber < 1) || (userNumber > 4))
    {
        Console.WriteLine($"{userNumber} не является порядковым номером четверти координат!");
    }
    else if (userNumber == 1)
    {
        Console.WriteLine($"Для четверти координат {userNumber}: Х > 0, Y > 0");
    }
    else if (userNumber == 2)
    {
        Console.WriteLine($"Для четверти координат {userNumber}: Х < 0, Y > 0");
    }
    else if (userNumber == 3)
    {
        Console.WriteLine($"Для четверти координат {userNumber}: Х < 0, Y < 0");
    }
    else
    {
        Console.WriteLine($"Для четверти координат {userNumber}: Х > 0, Y < 0");
    }
}