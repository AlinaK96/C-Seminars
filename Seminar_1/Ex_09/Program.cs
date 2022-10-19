// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine() ?? "0");

int first = number / 10;
int second = number % 10;

if (first > second)
{
    Console.WriteLine("Maximum = "+first+"");
}
else
    Console.WriteLine("Maximum = "+second+"");