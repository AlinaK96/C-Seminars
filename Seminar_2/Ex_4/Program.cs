// Программа проверяет пятизначное число на палиндромом
    // Палиндромом называется число, которое читается одинаково слева направо и справа налево. Например: 121

Console.WriteLine("Введите пятизначное число:");
int Number = int.Parse(Console.ReadLine() ?? "0");

int lastNubmer = (Number % 10);
int firstNumber = (((Number / 10)/10)/10)/10;

int secondNumber = (((Number / 10)/10)/10) %10;
int fourthNumber = (Number / 10) %10;


if ((firstNumber == lastNubmer) && (secondNumber == fourthNumber))
{
    Console.WriteLine(+Number+ " является палиндромом");
}

else
    Console.WriteLine(+Number+ " не является палиндромом");
