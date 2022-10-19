//  Дано число обозначающее день недели. Выяснить является номер дня недели выходным

Console.WriteLine("Для определения дня недели - ведите число :");
int number = int.Parse(Console.ReadLine() ?? "0");

if (number < 6)
{
    Console.Write("Рабочий день");
}

else if(number ==6)
{
    Console.WriteLine("Выходной");
}
else if(number ==7)
{
    Console.WriteLine("Выходной");
}

else 
    Console.WriteLine("Попробуйте еще раз");
