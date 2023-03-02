// Вывод дня недели по номеру
Console.Clear();
Console.Write("Ведите порядковый номер дня недели: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num < 1 || num > 7)
{
    Console.WriteLine("Учи календарь! Нет в нашей неделе такого дня!");
    return;
}
else
{
    if (num == 1) Console.WriteLine("Это тяжелый день понедельник, братан!");
    else if (num == 2) Console.WriteLine("Это вторник!");
    else if (num == 3) Console.WriteLine("Это середина недели, среда!");
    else if (num == 4) Console.WriteLine("Четверг, еще немного!");
    else if (num == 5) Console.WriteLine("Пятница пришла!");
    else if (num == 6) Console.WriteLine("А вот и выходные, суббота!");
    else if (num == 7) Console.WriteLine("Воскресенье, завтра работать!");
}
