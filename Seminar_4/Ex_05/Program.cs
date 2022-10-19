// Найти сумму чисел одномерного массива стоящих на нечетной позиции

int n = 10;
int min = 2;
int max = 21;

int[] CreateArray(int n, int min, int max)
{
    int[] array = new int[n];

    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

void PritArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int[] EvenIndex (int[] arr)
{
    int[] even = new int[1];
    for (int i = 0; i < arr.Length; i++)
    {
        if ((i % 2) == 0) even[0]+= arr[i];
    }
    return even;
}

int[] array = CreateArray(n, min, max); 

Console.Write("Массив: ");
PritArray(array);

Console.Write("Сумма чисел с нечётный индексом = ");
PritArray(EvenIndex(array));
