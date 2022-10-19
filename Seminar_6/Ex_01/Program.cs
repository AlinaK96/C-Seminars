// Показать двумерный массив размером m×n заполненный вещественными числами

double[,] PrintArray(int m, int n)
{
    double[,] matr = new double[m, n];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] =  new Random().NextDouble() * 10;
        }
    }
    return matr;
}

void FillArray(double[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + "    ");
        }
        Console.WriteLine();
    }
}

Console.Write("Количество строк: ");
int m = int.Parse(Console.ReadLine()?? "0");
Console.Write("Количество столбцов: ");
int n = int.Parse(Console.ReadLine()?? "0");

double[,] matrix = PrintArray(m, n);
FillArray(matrix);