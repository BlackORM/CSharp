// Заполняем рандомно массив и ищем соответствие с заданным числом
void FillArray(int[] numbers) //метод для заполнения
{
    int length = numbers.Length;
    int index = 0;
    while (index < length)
    {
        numbers[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] num) //метод для вывода
{
    int col = num.Length;
    int pos = 0;
    while (pos < col)
    {
        Console.Write(num[pos] + " ");
        //Console.Write(" ");
        pos++;
    }
}

int IndexFind(int[] numbers, int find) //поиск индекса
{
    int count = numbers.Length;
    int index = 0;
    int posit = -1;
    while (index < count)
    {
        if (numbers[index] == find)
        {
            posit = index;
            break;
        }
        index++;
    }
    return (posit);
}

int[] array = new int[10];

Console.Clear();
Console.Write("Введите число от 1 до 10 индекс которого будем искать: ");
int usernum = Convert.ToInt32(Console.ReadLine());
FillArray(array);
Console.Write("Рандомный массив: ");
PrintArray(array);
Console.WriteLine();
int pos = IndexFind(array, usernum);
if (pos == -1) Console.WriteLine("Такого числа в массиве нет!");
else
{
    Console.Write("Индекс вашего числа (" + usernum + ") в массиве: ");
    Console.WriteLine(pos);
}