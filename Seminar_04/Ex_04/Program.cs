﻿//Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
// тип[] название_массива

int[] array = new int[8];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 2);
}

for (int i = 0; i < array.Length; i++)
{
    Console.Write(array[i] + ", ");
}
