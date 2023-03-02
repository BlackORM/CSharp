// Вводим трехзначное число и показываем вторую цифру
Console.Clear();
int num, num1;
while (true) //Проверка корректности ввода из семинара
{
    Console.Write("Введите трехзначное число: ");
    if (int.TryParse(Console.ReadLine(), out num))
    {
        num1 = num; //сохраняем введенное число для вывода
        num = Math.Abs(num); //берем модуль чтобы работало с отрицательными числами (не изучали гугл в помощь)
        if (num > 99 && num < 1000)
            break;
    }
    Console.WriteLine("Введите правильное ТРЕХЗНАЧНОЕ число!");
}
//int num = new Random().Next(100, 1000); //здесь число может создаваться рандомно
int a1 = num / 100;
int a2 = (num / 10) % 10;
int a3 = num % 10;
int sum = a1 * 10 + a3;
Console.WriteLine($"Ввели число: {num1}");
Console.WriteLine($"Вторая цифра в числе {num1} это: {a2}");
Console.WriteLine($"А также! Первая цифра числа {num1} это: {a1}, а последняя: {a3}");