// Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива

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

void SortArray (int[,] matr, int rowNumber)
{
    int change;
    for ( int i = 0; i < matr.GetLength(1); i++)
    {
        for (int j = 1; j < matr.GetLength(1) - i; j++)
        {
            if (matr[rowNumber, j - 1] < matr[rowNumber, j])
            {
                change = matr[rowNumber, j];
                matr[rowNumber, j] = matr[rowNumber, j - 1];
                matr[rowNumber, j - 1] = change;
            }
        }
    }
}

int[,] matrix = new int[3, 5];

FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();

for (int i = 0; i < matrix.GetLength(0); i++)
{
    SortArray(matrix, i);
}
Console.WriteLine();
PrintArray(matrix);