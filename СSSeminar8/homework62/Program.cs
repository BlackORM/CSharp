// Напишите программу, которая заполнит спирально массив 4 на 4

Console.Clear();
int[,] array = new int[4, 4];
SpiralArray(array);
PrintArray(array);

//заполнение массива спирально 
int[,] SpiralArray(int[,] inArray)
 { 
     int temp = 1; 
     int i = 0; 
     int j = 0; 

     while (temp <= inArray.GetLength(0) * inArray.GetLength(1)) 
     { 
         inArray[i, j] = temp; 
         temp++; 
         if (i <= j + 1 && i + j < inArray.GetLength(1) - 1) 
             j++; 
         else if (i < j && i + j >= inArray.GetLength(0) - 1) 
            i++;
         else if (i >= j && i + j > inArray.GetLength(1) - 1) 
             j--; 
         else 
             i--; 
     } 
     return inArray; 
 } 

//печать массива 
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] / 10 <= 0)
                Console.Write($" {array[i, j]} ");

            else Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}
