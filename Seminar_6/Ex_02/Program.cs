// Задать двумерный массив следующим правилом: Aₘₙ = m+n

int[,] PrintArray (int row, int col)
{
    int[,] matr = new int[row, col];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = i + j;
        }
    }
    return matr;
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + "  " );
        }
        Console.WriteLine();
    }
}

int m = new Random().Next(5, 11);
int n = new Random().Next(10, 16);

int[,] matr = PrintArray(m, n);
FillArray(matr);