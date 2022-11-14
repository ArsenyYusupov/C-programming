//Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
string strNumber = Math.Abs(number).ToString();
Console.WriteLine(strNumber.Length);