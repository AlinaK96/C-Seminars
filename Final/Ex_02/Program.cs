// Найти сумму элементов от M до N, N и M заданы


Console.Write("Введите число M: ");
int numberM = int.Parse(Console.ReadLine()?? "0");
Console.Write("Введите число N: ");
int numberN = int.Parse(Console.ReadLine()?? "0");

int Sum (int start, int end)
{
    if (start == end) return start;
    return (start + Sum(start + 1, end));
}

Console.Write($"Сумма чисел от {numberM} до {numberN} равна {Sum(numberM, numberN)}");
