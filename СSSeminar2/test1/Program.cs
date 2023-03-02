//Вводим целое число и проверяем правильность ввода
int a;
while(true)
{
    Console.Write("Введите число: ");
    if(int.TryParse(Console.ReadLine(), out a))
        break;
    Console.WriteLine("Введите правильное число!");
}
Console.WriteLine($"{a}");