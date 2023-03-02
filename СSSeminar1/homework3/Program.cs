// Определяем четное число или нет
Console.Clear();
Console.WriteLine("Введите число и я скажу четное оно или нет!");
Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num % 2 == 0) Console.Write($"Число {num} четное!");
else Console.Write($"Число {num} нечетное!");