// Задача 45: Напишите программу, которая будет создавать копию заданного массива с 
// помощью поэлементного копирования.

void Main()
{
    Console.Clear();
    int[] ourArray = { 1, 2, 3, 4, 5 };
    int[] copiedArray = GetArrCopy(ourArray);
    PrintArray(copiedArray);
}

int[] GetArrCopy(int[] arr)
{
    int[] newArray = new int[arr.Length];
    for (int i = 0; i < arr.Length; i++)
    {
        newArray[i] = arr[i];
    }
    return newArray;

}

void PrintArray(int[] arr)
{
    Console.WriteLine("\nNew array");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($" {arr[i]} ");
    }
}
Main();