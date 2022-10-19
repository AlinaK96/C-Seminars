// Найти расстояние между точками в пространстве 3D
      // x1, y1, z1 = (10, 8, 6)   / x2, y2, z1 = (3, 4, 5)
      // sqrt {(x2-x1) ^{2} + (y2-y1) ^{2} + (z2-z1) ^{2}} = sqrt (66)

Console.Write("x1 = ");
double x1 = int.Parse(Console.ReadLine()??"");

Console.Write("y1 = ");
double y1 = int.Parse(Console.ReadLine()??"");

Console.Write("z1 = ");
double z1 = int.Parse(Console.ReadLine()??"");

Console.Write("x2 = ");
double x2 = int.Parse(Console.ReadLine()??"");

Console.Write("y2 = ");
double y2 = int.Parse(Console.ReadLine()??"");

Console.Write("z2 = ");
double z2 = int.Parse(Console.ReadLine()??"");


double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
Console.WriteLine("Расстояние между тремя точками в пространстве = " +distance+ "");