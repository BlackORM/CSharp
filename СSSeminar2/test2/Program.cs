// Убираем из случайного трехзначного числа среднюю цифру
Console.Clear();
int num = new Random().Next(100, 1000);
int a1 = num / 100;
int a2 = (num / 10) % 10;
int a3 = num % 10;
int sum = a1 * 10 + a3;
Console.WriteLine($"Выпало число: {num}");
Console.WriteLine($"Исключили из числа {num} цифру {a2} и получили {sum}");
