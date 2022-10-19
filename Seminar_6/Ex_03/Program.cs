// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i,j]} ");
        }
        Console.WriteLine();
    }
}

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for( int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i,j] = new Random().Next(1,45);
        }
    }
}

void ChangeArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if ((i % 2 == 0) && (j % 2 == 0)) matr[i,j] *= matr[i,j];
            else matr[i,j] = matr[i,j];
        }
    }
    
}


Console.Write("Введите количество строк: ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите количество столюцов: ");
int m = int.Parse(Console.ReadLine() ?? "0");

int[,] matrix = new int[n,m];


FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();

ChangeArray(matrix);
PrintArray(matrix);