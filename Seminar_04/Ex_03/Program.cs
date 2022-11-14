//Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

int GetSum(int number)
{
  int sum = 1;
  
  /*int tempValue = 1;
  while (tempValue <= number)
  {
   sum = sum + tempValue;
   tempValue = tempValue + 1;
  }*/
   for (int i = 1; i <= number; i++)
   {
     sum = sum * i;
   }

  return sum;
}

Console.Write("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int sum = GetSum(number);
Console.WriteLine(sum);