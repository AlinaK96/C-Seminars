/* Написать программу, которая в двумерном массиве заменяет строки на столбцы
 или сообщить, что это невозможно (в случае, если матрица не квадратная)*/


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

int[,] ChangeArray(int[,] matr)
{
    int[,] changed = new int[matr.GetLength(0), matr.GetLength(0)];
    for(int i = 0; i < changed.GetLength(0); i++)
    {
        for (int j = 0; j < changed.GetLength(1); j++)
        {
            changed[j,i] = matr[i,j];
        }
    }
    return changed;
}

Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine()??"0");
Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine()??"0");

if (m!=n)
{
    Console.WriteLine("Поменять строки местами в данном массиве невозможно.");
    return;
}


int[,] matrix = new int[m, n];
Console.WriteLine("Массив:");
Console.WriteLine();
FillArray(matrix);
PrintArray(matrix);

Console.WriteLine();
int[,] ChangedArray = ChangeArray(matrix);
PrintArray(ChangedArray);
FillArray(ChangedArray);