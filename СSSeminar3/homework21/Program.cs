// Считаем расстояние между двумя 3Д точками
Console.Clear();
//Ввод координат
int x1 = Coord("Введите координату х1: ");
int y1 = Coord("Введите координату у1: ");
int z1 = Coord("Введите координату z1: ");
int x2 = Coord("Введите координату х2: ");
int y2 = Coord("Введите координату у2: ");
int z2 = Coord("Введите координату z2: ");

//Вывод ответа
Console.WriteLine($"Расстояние между точками ({x1}, {y1}, {z1}) и ({x2}, {y2}, {z2}) {Dist(x1, y1, z1, x2, y2, z2)}");

//Обработка ввода координат
static int Coord(string message)
{
    while (true)
    {
        try
        {
            Console.Write(message);
            return (int.Parse(Console.ReadLine() ?? ""));
        }
        catch (Exception exc)
        {
            Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
            
        }
    }
}

//Рассчет расстояния
static double Dist(int x1, int y1, int z1, int x2, int y2, int z2)
{
    return Math.Sqrt(Math.Pow(x2 - x1, 2) + (Math.Pow(y2 - y1, 2)) + (Math.Pow(z2 - z1, 2)));
}
