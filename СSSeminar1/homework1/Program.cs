// Определяем какое число из двух больше
Console.Clear();
Console.WriteLine("Введите два числа и я назову наибольшее!");
Console.Write("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if (num1 == num2) Console.Write("Ваши числа равны!");
else if (num1 > num2) Console.Write("Вы ввели " + num1 + " и " + num2 + ". Самое большое из них: " + num1);
else Console.Write("Вы ввели " + num1 + " и " + num2 + ". Самое большое из них: " + num2);