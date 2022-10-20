// Напишите программу которая на хвод принимает два числа и вычисляет не является ли одно квадратом другого
Console.WriteLine("Введите число №1 ... ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число №2 ... ");
int numberB = Convert.ToInt32(Console.ReadLine());
if (numberA == numberB*numberB)
{
    Console.WriteLine($"True: число №1 = {numberA} является квадратом числа №2 = {numberB}");
}
else
{
    Console.WriteLine($"False: число №1 = {numberA} НЕ является квадратом числа №2 = {numberB}");
}