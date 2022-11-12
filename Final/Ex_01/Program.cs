// Показать натуральные числа от M до N


Console.Write("Введите число M: ");
int numberM = int.Parse(Console.ReadLine()?? "0");
Console.Write("Введите число N: ");
int numberN = int.Parse(Console.ReadLine()?? "0");

string PrintArray (int start, int end)
{
    if(start == end) return start.ToString();
    return (start + " " + PrintArray(start+1, end));
}


Console.Write(PrintArray(numberM, numberN));