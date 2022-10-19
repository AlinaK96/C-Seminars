// Показать четные числа от 1 до N


Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine() ?? "0");
int number1 = 1;

while (number1 <= number)
{
    if (number1 % 2 == 0)
    {
       Console.WriteLine(number1); 
    }
    
    number1++;
    
}

