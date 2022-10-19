// Показать кубы чисел, если куб заканчивается на чётную цифру

Console.WriteLine("Введите число:");
double N = double.Parse(Console.ReadLine()?? "0");
double count = 1;

while (count <= N)
{
    if (count % 2 == 0)
    {
        double pow = Math.Pow(count, 3);
        Console.WriteLine(pow);
    }

    count++;
}