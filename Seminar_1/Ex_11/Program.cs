// Выяснить, кратно ли число заданному, если нет, вывести остаток.

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Кратно ли "+number+ " числу: ");
int number1 = int.Parse(Console.ReadLine() ?? "0");
int del = number % number1;

if (del == 0)
{
    Console.WriteLine("Кратно");
}

else
    Console.WriteLine("не кратно");