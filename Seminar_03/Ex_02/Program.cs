//Напишите программу, которая по заданному номеру четверти,
// показывает диапазон возможных координат точек в этой четверти (x и y).

//Console.WriteLine("Введите номер четверти:");
//int n = Convert.ToInt32(Console.ReadLine());
//if (n == 1)
//{
//  Console.WriteLine("x > 0, y > 0");
//}
//if (n == 2)
//{
//  Console.WriteLine("x < 0, y > 0");
//}
//if (n == 3)
//{
//  Console.WriteLine("x < 0, y < 0");
//}
//if (n == 4)
//{
//  Console.WriteLine("x > 0, y < 0");
//}

string GetCoordArea(int chetvert)
{
  string coords = "";
  if (chetvert == 1) coords = "x > 0, y > 0";
  if (chetvert == 2) coords = "x < 0, y > 0";
  if (chetvert == 3) coords = "x < 0, y < 0";
  if (chetvert == 4) coords = "x > 0, y < 0";
  return coords;
}

Console.WriteLine("Vvedi nomer chetverti ");
int n = Convert.ToInt32(Console.ReadLine());

string coords = GetCoordArea(n);
Console.WriteLine($"Vozmozhnie coordinati: {coords}");