// Найти кубы чисел от 1 до N

Console.WriteLine("Введите число:");
double N = double.Parse(Console.ReadLine()?? "0");
double count = 1;

while (count <= N)
 {
    double result = Math.Pow(count, 3);
    Console.WriteLine ("Куб числа " +count+ " = " +result);
    count++;

 }