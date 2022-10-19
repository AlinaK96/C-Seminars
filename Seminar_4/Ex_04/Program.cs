// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int n = 123;
int min = new Random().Next(-999,40);
int max = new Random().Next(41,999);

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

void CheckNumber(int[] arr)
{
    int count = 0;
    for (int i = 0; i < n; i++)
    {
        if((arr[i] >= 10) && (arr[i] <= 99)) count++;
        
    }
    Console.WriteLine();
    Console.WriteLine("Количество чисел из диапазона [10, 99] равно " +count+"");
    Console.WriteLine();
}


int[] array = CreateArray(n, min, max); 

Console.Write("Массив: ");
PrintArray(array);

CheckNumber(CreateArray(n, min, max));