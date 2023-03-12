// Создание двумерного массива
Console.WriteLine("Создаем двумерный массив");
string[,] table = new string[2, 3];

for (int i = 0; i < table.GetLength(0); i++)
{
    for (int j = 0; j < table.GetLength(1); j++)
    {
        Console.Write("0 ");
    }
    Console.WriteLine();
}

