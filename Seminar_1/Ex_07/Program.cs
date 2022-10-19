// Показать последнюю цифру трёхзначного числа

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine() ?? "0");
int lastnumber = (number % 10);

Console.WriteLine(lastnumber);