// Определяем кратно ли число 7 и 23
Console.Clear();
Console.WriteLine("Определим кратно ли ваше число 7 и 23, дерзайте!");
Console.Write("Введите число: ");
int num1 = int.Parse(Console.ReadLine());

if (num1 % 7 == 0 && num1 % 23 == 0)
    Console.WriteLine($"Число {num1} кратно 7 и 23");
else 
    Console.WriteLine($"Число {num1} не кратно 7 и 23");
