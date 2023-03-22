// See https://aka.ms/new-console-template for more information
Console.WriteLine();
int rows = StringMessage("Введите rows: ", "Ошибка ввода.");
int col = StringMessage("Введите col: ", "Ошибка ввода.");
int[,] array = GetArray(rows, col);
PrintArray(array);
int[] temp = FrequenceElement(array);
Console.WriteLine($"{String.Join(", ", temp)}");
SortMassive(temp);
Console.WriteLine($"{String.Join(", ", temp)}");
Console.WriteLine();
PrintResult(temp);

void PrintResult(int[] array)
{
    int count = 1;
    int number = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (number == array[i]) count++;
        else 
        {
            Console.WriteLine($"{number} встречается {count} раз");
            count = 1;
            number = array[i];
        }
    }
    Console.WriteLine($"{number} встречается {count} раз");
}



void SortMassive(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        for (int j = 0; j < array.Length - 1; j++)
            if (array[j] > array[j + 1])
            {
                int a = array[j + 1];
                array[j + 1] = array[j];
                array[j] = a;
            }
}

int[] FrequenceElement(int[,] array)
{
    int[] arr = new int[array.GetLength(0) * array.GetLength(1)];
    int k = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            arr[k] = array[i, j];
            k++;
        } 
    }
    return arr;
} 

int[,] GetArray(int rows, int col)
{
    int[,] arr = new int[rows, col];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(0, 10);
        }
    }
    return arr;
} 

int StringMessage(string msg, string error)
{
    while (true)
    {
        Console.Write(msg);
        bool IsCorrect = int.TryParse(Console.ReadLine(), out int kek);
        if (IsCorrect)
        {
            return kek;
        }
        Console.WriteLine(error);
    }
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j]} ");
        }
        Console.WriteLine();
    }
}