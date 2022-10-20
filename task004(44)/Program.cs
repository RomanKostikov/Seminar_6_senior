// Задача 44: Не используя рекурсию, выведите первые N чисел 
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

void Main()
{
    Console.Clear();
    int N = GetNumber();
    double [] fib = Fibonacci(N);
    PrintArray(fib);
}
int GetNumber()
{
    Console.WriteLine("Enter number:");
    int num = int.Parse(Console.ReadLine()!);
    return num;
}
double[] Fibonacci(int n)
{
    double[] arr = new double[n];

    arr[0] = 0;

    for (int i = 1; i < n; i++)
    {
        if (i == 1)
        {
            arr[i] = 1;
        }
        else
        {
            arr[i] = arr[i - 1] + arr[i - 2];

        }

    }
    return arr;
}

void PrintArray(double[] arr)
{
    Console.WriteLine("\nArray:");
    for ( int i = 0; i<arr.Length; i++)
    {
        Console.Write($" {arr[i]} ");
    }
}

Main();