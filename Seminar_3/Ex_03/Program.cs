// Написать программу вычисления произведения чисел от 1 до N

Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine()?? "0");
int count = 1;
int dif = 1;

while (count <= N)
{

    dif = dif * count;
    count++;
}
 Console.WriteLine ("Произведение чисел = " +dif);