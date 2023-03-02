// Определяем является ли одно число квадратом другого
Console.Write("Введите первое число: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = int.Parse(Console.ReadLine());
if (num1 < num2)
{
    int tmp = num1;
    num1 = num2;
    num2 = tmp;
}
if (num1 == (int)Math.Pow(num2, 2) || num2 == (int)Math.Pow(num1, 2))
    Console.WriteLine($"Число {num1} является квадратом числа {num2}");
else
    Console.WriteLine($"Число {num1} не является квадратом числа {num2}");