/*Написать программу показывающие первые N чисел, для которых каждое следующее равно сумме двух предыдущих. 
Первые два элемента последовательности задаются пользователем*/

int FillArray(int numberA, int numberB, int amountNumber)
{
    int number3 = 0;
    if (amountNumber <= 1)
    {
        number3 = numberA + numberB;
    }
    if (amountNumber + 1 > 1)
    {
        number3 = numberA + numberB;
        numberA = numberB;
        numberB = number3;
        amountNumber = amountNumber - 1;
        Console.Write($"{number3} ");
        FillArray(numberA, numberB, amountNumber);
    }
    return number3;
}

Console.Write("Введите первый элимент: ");
int number1 = int.Parse(Console.ReadLine()?? "0");
Console.Write("Введите второй элимент: ");
int number2 = int.Parse(Console.ReadLine()?? "0");

Console.Write("Введите длину числового массива: ");
int length = int.Parse(Console.ReadLine() ?? "0");

Console.Write($"{number1} ");
Console.Write($"{number2} ");
FillArray(number1, number2, length);