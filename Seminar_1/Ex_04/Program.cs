// Показать четные числа от 1 до N

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine() ?? "0");

if (number % 2 == 0)
Console.WriteLine(+number+" - Является чётным числом");

else
Console.WriteLine(+number+" - Является нечётным числом");