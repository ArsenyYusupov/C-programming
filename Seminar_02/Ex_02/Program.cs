//Напишите программу, которая выводит случайное трёхзначное число
// и удаляет вторую цифру этого числа.
var rand = new Random();
int numbs = rand.Next(100, 1000);
int first, last, result;
Console.WriteLine(numbs);
last = numbs % 10;
first = numbs / 100;
result = first*10 + last;

Console.WriteLine($"Случайное число без второй цифры равно: {result}");