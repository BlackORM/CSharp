// Определяем кратно ли одно число другому и если не кратно выводим остаток
Console.Clear();
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
if (num1 % num2 == 0)
    Console.WriteLine($"Число {num1} кратно {num2}");
else
    Console.WriteLine($"Число {num1} не кратно {num2}, остаток от деления: {num1 % num2 % 10}");
