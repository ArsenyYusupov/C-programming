﻿//Напишите программу, которая принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
 //Для решения задания использование цикла for является обязательным условием.
  //Не использовать встроенный метод возведения в степень.
  
int numberA = ReadInt("Введите число A: ");
int numberB = ReadInt("Введите число B: ");
ToDegree(numberA, numberB);


// Функция возведения в степень
void ToDegree(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }
    Console.WriteLine(result);
}

// Функция ввода
int ReadInt(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}