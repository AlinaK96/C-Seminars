// Показать вторую цифру трёхзначного числа

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine() ?? "0");
int midnumber = (number/10)%10;


Console.WriteLine(midnumber);