// Показать треугольник Паскаля *Сделать вывод в виде равнобедренного треугольника

int Fuctorial (int n)
{
    int f = 1;
    for(int i = 1; i <=n; i++)
    {
        f *= i;
    }
    return f;
}

void Print(int n)
{
    for ( int i = 0; i < n; i++)
    {
        for (int j = 0; j <= (n-i); j++)
        {
            Console.Write("  ");
        }
        for (int j = 0; j <=i; j++)
        {
            Console.Write("  ");
            Console.Write(Fuctorial(i) / (Fuctorial(j)*Fuctorial(i-j)));
        }
        Console.WriteLine();
    }
}


Console.Clear();
Console.Write("Количество строк: ");
int rows = int.Parse(Console.ReadLine()?? "0");
Print(rows);

