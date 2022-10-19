// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

int n = 25;
int min = new Random().Next(100,599);
int max = new Random().Next(600,999);

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

void EvenNumber (int[] arr)
{
    int numberEven = 0;
    int numberOdd = 0;
    int[] even = new int[2];
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0 ) numberEven++;
        else numberOdd++;
    }
        Console.WriteLine();
        Console.WriteLine("Количество чётных чисел " +numberEven+"");
        Console.WriteLine("Количество нечётных чисел " +numberOdd+"");
        Console.WriteLine();
}

int[] array = CreateArray(n, min, max); 

Console.Write("Массив: ");
PrintArray(array);
EvenNumber(CreateArray(n,min,max));