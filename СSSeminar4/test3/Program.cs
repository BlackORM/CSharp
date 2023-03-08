// Заполнить массив из 8 рандомно 0 и 1
int[] array = new int[8]; 
FillArray(array); 
//PrintArray(array); 
Console.WriteLine($"[{String.Join(",", array)}]"); 
 
void FillArray(int[] array) 
{ 
    int length = array.Length; 
    for (int i = 0; i < length; i++) 
    { 
        array[i] = new Random().Next(0, 2); 
    } 
} 
 
//void PrintArray(int[] array) 
//{ 
//    int length = array.Length; 
//    Console.Write("["); 
//    for (int i = 0; i < length; i++) 
//    { 
//        Console.Write($"{array[i]}"); 
//        if (i < length - 1) Console.Write(", "); 
//    } 
//    Console.Write("]"); 
//}
