/*Сформировать трехмерный массив не повторяющимися двузначными числами показать 
его построчно на экран выводя индексы соответствующего элемента*/



void FillArray(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int z = 0; z < matr.GetLength(2); z++)
            {
                matr[i, j, z] = new Random().Next(10, 50);
            } 
        }
    }
}

void PrintArray(int[,,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            for (int z = 0; z < matr.GetLength(2); z++)
            {
                Console.Write($"({i},{j},{z}) = {matr[i, j, z]}   ");
            }
        }
        Console.WriteLine();
    }
}


Console.Write("Количество строк: ");
int m = int.Parse(Console.ReadLine()??"0");
Console.Write("Количество столбцов: ");
int n = int.Parse(Console.ReadLine()??"0");
Console.Write("Bведите глубину: ");
int p = int.Parse(Console.ReadLine()??"0");
int[,,] matrix = new int[m, n, p];
Console.WriteLine("Трехмерный массив: ");
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
