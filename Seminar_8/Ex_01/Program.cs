// Найти произведение двух матриц

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

int[,] Multiply (int[,] matr1, int[,] matr2) 
{
    int[,] multiplication = new int[matr1.GetLength(0), matr1.GetLength(1)];
    for (int i = 0; i < matr1.GetLength(0); i++)
    {
        for (int j = 0; j < matr1.GetLength(1); j++)
        {
            for (int k = 0; k < matr1.GetLength(0); k++)
            {
                multiplication[i, j] += matr1[i, k] * matr2[k, j];
            }
        }
    }
    return multiplication;
}

Console.WriteLine("Умножение возможно, только если количество строк и столбцов матрицы совпадают!");
Console.Write("Введите количество строк: ");
int m = int.Parse(Console.ReadLine()??"0");
Console.Write("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine()??"0");

int[,] matrix1 = new int[m, n];
Console.WriteLine("Первая матрица: ");
FillArray(matrix1);
PrintArray(matrix1);
Console.WriteLine();

Console.WriteLine("Вторая матрица: ");
int[,] matrix2 = new int[m, n];
FillArray(matrix2);
PrintArray(matrix2);
Console.WriteLine();

Console.WriteLine("Произведение двух матриц: ");
int[,] resultmatrix = new int[m, n];
resultmatrix = Multiply(matrix1, matrix2);
PrintArray(resultmatrix);