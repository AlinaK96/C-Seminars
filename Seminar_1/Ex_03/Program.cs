
// Найти максимальное из трех чисел
     

Console.WriteLine("Введите a: ");
int a1 = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите b: ");
int b1 = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("Введите c: ");
int c1 = int.Parse(Console.ReadLine() ?? "0");
int Max = 0;

if ((a1 > b1) && (a1 > c1))
Max = a1;

else if ((b1 > a1) && (b1 > c1))
Max = b1;

else if ((c1 > a1) && (c1 > b1))
Max = c1;
Console.WriteLine(" Наибольшее число = "+Max+"");
    