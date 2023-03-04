// Показываем кубы чисел до введенного
Console.Clear();
int userNum = num("Введите целое число и я покажу все кубы до него: ");
if (userNum == 0) Console.WriteLine("У нуля любая степень равна нулю!");
else
{
    Console.Write($"Это все кубы числа до числа {userNum}: ");

    //считаем кубы
    int a = 1;
    if (userNum > 0)
    {
        while (a <= userNum)
        {
            Console.Write(Math.Pow(a, 3) + " ");
            a++;
        }
    }
    else
    {
        a = -1;
        while (a >= userNum)
        {
            Console.Write(Math.Pow(a, 3) + " ");
            a--;
        }
    }
}

//проверка ввода
static int num(string message)
{
    while (true)
    {
        try
        {
            Console.Write(message);
            return (int.Parse(Console.ReadLine() ?? ""));
        }
        catch (Exception exc)
        {
            Console.WriteLine($"Ошибка ввода данных! {exc.Message}");

        }
    }
}