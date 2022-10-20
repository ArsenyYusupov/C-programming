// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите число №1 ... ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число №2 ... ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число №3 ... ");
int numberC = Convert.ToInt32(Console.ReadLine());
int max = 0;
if (numberA > numberB) 
{
     max = numberA;
}
else
{
    max = numberB;
}
if (numberB > numberC)
{
    max = numberB;
}
else
{
    max = numberC;
}
if (numberC > numberA)
{
    max = numberC;
}
else
{
    max = numberA;
}
Console.WriteLine($"max = {max}");