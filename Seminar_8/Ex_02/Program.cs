// В двумерном массиве целых чисел. Удалить строку и столбец, на пересечении которых расположен наименьший элемент.

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

int[] MinIndex(int[,] matr)
{
    int[] result = new int[]{0,0};
    int min = matr[0,0];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if(matr[i,j] < min)
            {
                min = matr[i,j];
                result[0] = i;
                result[1] = j;
            }
        }
    }
    return result;
}

int[,] NewArray(int[,] matr, int[]index)
{
    int[,] result = new int[matr.GetLength(0) - 1, matr.GetLength(1)-1];
    int row = 0;
    int colums = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        if(i== index[0]) continue;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if(j==index[1]) continue;
            result[row,colums] = matr[i,j];
            colums++;
        }
        row++;
        colums = 0;
    }
    return result;
}

int[,] matrix = new int[3, 5];
Console.WriteLine("Первоначальная матрица: ");
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();

Console.Write($"Наименьший элимент находится в позиции: {String.Join(";", MinIndex(matrix))}");
Console.WriteLine();
Console.WriteLine("Изменённая матрица: ");
PrintArray(NewArray(matrix, MinIndex(matrix)));