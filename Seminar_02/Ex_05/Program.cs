//Напишите программу, которая принимает на вход два числа и проверяет,
// является ли одно число квадратом другого.
Console.WriteLine("Введите число №1: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число №2: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a * a == b || b * b == a)
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}