// По двум заданным числам проверять является ли одно квадратом другого

Console.WriteLine("Введите число A:");
int number1 = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Введите число B:");
int number2 = int.Parse(Console.ReadLine() ?? "0");

if(number1 * number1== number2)
{
    Console.WriteLine(+number1+" - Является квадратом "+number2+"");
}

else 
{
    Console.WriteLine(+number2+ " - Не является квадратом "+number2+"");
}