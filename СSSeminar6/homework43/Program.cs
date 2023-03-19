// Напишите программу, которая найдёт точку пересечения двух прямых, 
//заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем.
//b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.Clear();
double b1 = InputNumber("Введите коэффициент b1: ", "Ошибка ввода данных!");
double k1 = InputNumber("Введите коэффициент k1: ", "Ошибка ввода данных!");
double b2 = InputNumber("Введите коэффициент b2: ", "Ошибка ввода данных!");
double k2 = InputNumber("Введите коэффициент k2: ", "Ошибка ввода данных!");
double x = Math.Round((b2 - b1) / (k1 - k2), 2);
double y = Math.Round(k1 * x + b1, 2);

if (k1 == k2 && b1 == b2)
{
    Console.WriteLine("Прямые совпадают!");
}
else
if (k1 == k2)
{
    Console.WriteLine("Прямые параллельны!");
}
else
{
    Console.WriteLine("Точка пересечения прямых с коэффициентами:");
    Console.WriteLine($"b1 = {b1}, k1 = {k1}, b2 = {b2}, k1 = {k1} => ({x} , {y})");
}



double InputNumber(string message, string errormessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = double.TryParse(Console.ReadLine(), out double userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errormessage);
    }
}


