// В прямоугольной матрице найти строку с наименьшей суммой элементов

int min = new Random().Next(1, 4);
int max = new Random().Next(5, 9);

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($" {matr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(min, max + 1);
        }

    }
}

void MinimalIndex(int[,] array)
{
    int min = int.MaxValue;
    int count = 0;
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum +=array[i, j];
        }    
    if (min > sum)
    {
        min = sum;
        count = i;
    }
    sum = 0;
    }
    Console.Write($"Наименьшая сумма элиментов ({min}) находится на строке № {count + 1}");
}

int[,] matrix = new int[3, 5];

FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
MinimalIndex(matrix);