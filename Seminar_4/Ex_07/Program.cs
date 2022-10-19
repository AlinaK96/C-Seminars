// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

int n = 25;
int min = new Random().Next(1,50);
int max = new Random().Next(51,99);

int[] CreateArray(int n, int min, int max)
{
    int[] array = new int[n];

    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void Difference(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i]);
        }
    int difference = arr.Max() - arr.Min();
    Console.WriteLine();
    Console.WriteLine($"Минимальное значение массива {arr.Min()}, максимальное значение массива {arr.Max()}");
    Console.WriteLine($"Разница между минимальным и максимальным значениями массива составляет {difference}");
    System.Console.WriteLine();
}

int[] array = CreateArray(n, min, max); 

Console.Write("Массив: ");
PrintArray(array);

Difference (CreateArray(n, min, max));

