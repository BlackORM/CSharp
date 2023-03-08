// Заполнить массив из 8 чисел пользователем и вывести на экран
Console.Clear();
//Заполняем массив
Console.WriteLine("Ведите 8 элементов массива");
int[] array = new int[8];
FillArray(array);
//Выводим массив
Console.WriteLine($"[{String.Join(",", array)}]");
//Предлагаем отсортировать
//Console.Write("Хотите отсортировать массив?(Y/N): ");
BubbleSort(array);
Console.WriteLine($"[{String.Join(",", array)}]");

void FillArray(int[] array)
{
    int length = array.Length;
    for (int i = 0; i < length; i++)
    {
        array[i] = GetNumberFromUser($"Введите целое число {i + 1}: ", "Ошибка ввода!");
    }
}

int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect) return userNumber;
        Console.WriteLine(errorMessage);
    }
}

void BubbleSort(int[] array)
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