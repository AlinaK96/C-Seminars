// Задать номер четверти, показать диапазоны для возможных координат

Console.WriteLine("Для определения диапазона возможных координат задайте номер четверти:");
int quarterNumber = int.Parse(Console.ReadLine() ?? "0");
string range = "";

//string num = "";

if (quarterNumber == 1) range = "x > 0, y > 0";
else if (quarterNumber == 2) range = "x < 0, y > 0";
else if (quarterNumber == 3) range = "x < 0, y < 0";
else if (quarterNumber == 4) range = "x > 0, y < 0";
else range = "Error";

Console.WriteLine("Для "+quarterNumber+"-й четверти координаты точки должны быть заданы в диапазоне ( "+range+" )");
