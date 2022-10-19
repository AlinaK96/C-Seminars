// По заданному номеру дня недели вывести его название

Console.WriteLine("Для определения дня недели - ведите число :");
int number = int.Parse(Console.ReadLine() ?? "0");

if(number == 1)
{
    Console.WriteLine("День: Понедельник");
}
else if(number ==2)
{
    Console.WriteLine("День: Вторник");
}
else if(number ==3)
{
    Console.WriteLine("День: Среда");
}
else if(number ==4)
{
    Console.WriteLine("День: Четверг");
}
else if(number ==5)
{
    Console.WriteLine("День: Пятница");
}
else if(number ==6)
{
    Console.WriteLine("День: Субота");
}
else if(number ==7)
{
    Console.WriteLine("День: Воскресение");
}
else 
    Console.WriteLine("Попробуйте еще раз");