// Написать программу масштабирования фигуры

void PutCoordinatesInArray(int[,] coord)
{ 
    int count = coord.GetLength(0);
    for (int i = 0; i < count; i++)
    {
        Console.Write($"Введите координату x[{i}]: ");
         coord[i,0] = int.Parse(Console.ReadLine() ?? "0");
         Console.Write($"Введите координату y[{i}]: ");
         coord[i,1] = int.Parse(Console.ReadLine() ?? "0");
    }
}
void PrintArray(int[,] arr, int k)
{
    int length = arr.GetLength(0);
    for (int i = 0; i < length; i++)
    {
       Console.Write($"({arr[i,0] * k};{arr[i,1] * k}) " );
    }
    Console.WriteLine();
}
Console.Clear();
Console.Write("Введите кол-во вершин фигуры: ");
int count = int.Parse(Console.ReadLine() ?? "0");
int[,] coordinates = new int[count,2];
PutCoordinatesInArray(coordinates);
int k = 1;
Console.WriteLine("Координаты вершин фигуры до масштабирования:");
PrintArray(coordinates, k);
Console.WriteLine("Введите коэффициент k:");
k = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Координаты вершин фигуры после масштабирования:");
PrintArray(coordinates, k);