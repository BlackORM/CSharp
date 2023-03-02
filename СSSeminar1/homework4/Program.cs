// Выводим все четные числа до введенного
Console.Clear();
Console.WriteLine("Введите число и я покажу все четные числа до него!");
Console.Write("Введите целое число: ");
int num = Convert.ToInt32(Console.ReadLine());
int a = 0;
Console.Write($"Это все четные числа до числа {num}: ");
while (a <= num)
{
    Console.Write(a + " ");
    a += 2;
}
