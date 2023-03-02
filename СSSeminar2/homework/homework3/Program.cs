// Сегодня выходной?
Console.Clear();
int num;
while (true)
{
    Console.Write("Введите день недели от 1 до 7: ");
    if (int.TryParse(Console.ReadLine(), out num))
    {
        if (num > 0 && num < 8)
            break;
    }
    Console.WriteLine("Учи календарь! Нет в нашей неделе такого дня!");
}
if (num == 6 || num == 7) Console.Write("Ты заслужил выходной, отдыхай!");
else if (num == 1) Console.WriteLine("Рано расслабляться, понедельник! Неделя только началась!");
else if (num == 2) Console.WriteLine("Напряглись, еще только вторник!");
else if (num == 3) Console.WriteLine("Уже середина недели, но работа ждет!");
else if (num == 4) Console.WriteLine("Поднажмем, уже четверг. Еще пара дней!");
else if (num == 5) Console.WriteLine("Уже почти, но сегодня пятница и пашем!");
