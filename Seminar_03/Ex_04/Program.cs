//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.

void PrintSquaresToConsole(int n)
{
    for (int i = 1; i <= n; i++ )
    {
       Console.WriteLine(i * i);
    }
}

PrintSquaresToConsole(10);