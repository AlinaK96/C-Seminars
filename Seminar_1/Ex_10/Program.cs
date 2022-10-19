// Удалить вторую цифру трёхзначного числа

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine() ?? "0");
int lastnumber = (number % 10);
int firstnumber = (number/100)%10;

Console.Write(firstnumber);
Console.Write(lastnumber);