// Найти расстояние между точками в пространстве 2D

      // x1, y1 = (10, 8)   / x2, y2 = (3, 4)
      // sqrt {(x2-x1) ^{2} + (y2-y1) ^{2}} 

Console.Write("x1 = ");
double x1 = int.Parse(Console.ReadLine()?? "");

Console.Write("y1 = ");
double y1 = int.Parse(Console.ReadLine()?? "");

Console.Write("x2 = ");
double x2 = int.Parse(Console.ReadLine()?? "");

Console.Write("y2 = ");
double y2 = int.Parse(Console.ReadLine()?? "");


double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
Console.WriteLine("Расстояние между двумя точками в пространстве = " +distance+ "");