// Найти третью цифру числа или сообщить, что её нет

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine() ?? "0");
int lastnumber = (number % 10);

if (number / 100 > 0) 
{
    Console.WriteLine("Третьей цифрой числа " +number+ " является цифра: "+lastnumber+"");
}

else 
    Console.WriteLine("У числа "+number+ " нет третьей цифры");
