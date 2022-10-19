// Подсчитать сумму цифр в числе

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()?? "0");
int digit = 0;
int sumDigit = 0;
 
while (N != 0)
{
    digit = N % 10;
    sumDigit = sumDigit + digit;
    N = N / 10;
}

Console.WriteLine (sumDigit);
