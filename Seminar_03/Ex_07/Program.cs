//Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

/*Console.WriteLine("Введите число: ");
string number = Console.ReadLine();
int len = number.Length;

if (len == 5)
{
    if (number[0] == number[4] && number[1] == number[3])
    {
        Console.WriteLine($"{number} - Палиндром");
    }
    else
    {
        Console.WriteLine($"{number} - НЕ палиндром");
    }
}
else
{
    Console.WriteLine($"ОШИБКА: {number} - не является пятизначным");
}
*/
// Принимает на вход 5-ое число
bool IsPolindrome(int number)
{
   string strNumber = number.ToString();
   
   if (strNumber[0] == strNumber[4] && strNumber[1] == strNumber[3])
   {
    return true;
   }
   
    return false;
}


Console.Write("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number <= 9999 || number >= 100000)
{
    Console.WriteLine("Ввели некорректное число!(положительное)");
    return;
}

bool isPolindrome = IsPolindrome(number);
Console.WriteLine(isPolindrome);