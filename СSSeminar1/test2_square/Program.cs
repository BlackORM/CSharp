// Квадрат введенного числа 
Console.Clear();
Console.Write("Ведите число: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.Write("Ведите квадрат введенного числа: ");
int num2 = Convert.ToInt32(Console.ReadLine());
int itog = (int)Math.Pow(num, 2);
if (itog == num2) Console.WriteLine("Правильно!");
else Console.WriteLine("Вы не правы!");
