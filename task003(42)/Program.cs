// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3  -> 11
// 2  -> 10
// 1ое решение с использованием динамических массивов;
// ___________________________________________________
// void Main()
// {
//     Console.Clear();
//     int number = GetNumber();
//     // WriteArray(InBinary(number));
//     int[] result = InBinary(number);
//     // Console.WriteLine();
//     WriteArray(RevArray(result));
// }

// int GetNumber()
// {
//     Console.Write("Enter number: ");
//     int number = int.Parse(Console.ReadLine()!);
//     return number;
// }
// int[] InBinary(int number)
// {
//     int i = 0;
//     int a = 0;
//     int[] array = new int[0];
//     while (number >= 1)
//     {
//         Array.Resize(ref array, array.Length + 1);
//         a = number % 2;
//         array[i] = a;
//         i++;
//         number /= 2;
//     }
//     return array;
// }
// void WriteArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
// }
// int[] RevArray(int[] array)
// {
//     for (int i = 0; i < array.Length / 2; i++)
//     {
//         int k = array[i];
//         array[i] = array[array.Length - 1 - i];
//         array[array.Length - 1 - i] = k;
//     }
//     return array;
// }

// Main();

// 2ое решение без динамического массива;
// ______________________________________
// void Main()
// {
//     Console.Clear();
//     int number = GetNumber();
//     ChangeToBinary(number);
// }
// int GetNumber()
// {
//     Console.Write("Enter number: ");
//     int number = int.Parse(Console.ReadLine()!);
//     return number;
// }
// void ChangeToBinary(int number)
// {
//     int SIZE = 0;
//     int tempNumber = number;
//     for (int j = 0; tempNumber > 0; j++)
//     {
//         tempNumber = tempNumber / 2;
//         SIZE = j;
//     }
//     int[] arr = new int[SIZE + 1];
//     // Console.Write($"SIZE+1 = {SIZE + 1}");

//     for (int i = 0; number > 0; i++)
//     {
//         arr[SIZE - i] = number % 2;

//         number = number / 2;
//     }
//     Console.WriteLine(("\nНаше число = "));
//     for (int i = 0; i < arr.Length; i++)
//     {
//         Console.Write($"{arr[i]} ");
//     }
// }
// Main();

// 3ие решение через строки(преподаватель показал)
// _______________________________________________
int number = int.Parse(Console.ReadLine()!);
string res1 = Convert.ToString(number, 2);
Console.WriteLine(res1);