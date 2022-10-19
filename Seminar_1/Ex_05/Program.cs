// Показать числа от -N до N

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine() ?? "0");
int number2 = (number)*(-1);

while (number2 <= number)
{
    Console.WriteLine(number2);
    number2++;
}
