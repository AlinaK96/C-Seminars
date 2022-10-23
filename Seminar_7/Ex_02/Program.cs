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

int[,] matrix = new int[3, 5];

FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();