// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

int n = 11;
int min = new Random().Next(1,15);
int max = new Random().Next(16,30);

int[] CreateArray(int n, int min, int max)
{
    int[] array = new int[n];

    for(int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}

void PrintArray(int[] array)
{
    for( int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int[] Sum (int[] arr)
{
    int[] negative = new int[arr.Length / 2];
    int last = arr.Length - 1;
    for (int i = 0; i < arr.Length / 2; i++)
    {
        negative[i] = arr[i] * arr[last];
        last = last - 1;
    }
    if(arr.Length % 2 > 0) Console.WriteLine("Число " +arr[(arr.Length / 2)]+ " не имеет пары");
    return negative;
}


int[] array = CreateArray (n, min, max);
Console.Write("Массив: ");
PrintArray(array);
Console.WriteLine();
Console.WriteLine("Произведение пар:");
PrintArray(Sum(array));
