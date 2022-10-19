// Написать программу копирования массива

int[] GetArray(int size, int min, int max)
{
    int[] arr = new int[size];
    for (int i = 0; i < size; i++)
    {
        arr[i] = new Random().Next(min, max + 1);
    }
    return arr;
}

int[] CopyArray(int[] originArray)
{
    int[] copy = new int[originArray.Length];
    for (int i = 0; i < originArray.Length; i++)
    {
        copy[i] = originArray[i];
    }
    return copy;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        System.Console.Write(arr[i] + " ");
    }
}

int size = new Random().Next(5,10);
int min = new Random().Next(1,49);
int max = new Random().Next(50,99);

int[] origin = GetArray(size, min, max);
Console.Write("Исходный массив А: ");
PrintArray(origin);
Console.WriteLine();
Console.Write("Копия массива А: ");
int[] copy = CopyArray(origin);
PrintArray(copy);