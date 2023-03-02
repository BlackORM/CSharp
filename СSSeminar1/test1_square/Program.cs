// Квадрат введенного числа
Console.Clear();
Console.Write("Ведите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int itog = (int)Math.Pow(num, 2);
Console.WriteLine($"Квадрат числа {num} = {itog}");
Console.WriteLine("Квадрат числа " + num + " = " + itog);
