Console.Write("Введите номер дня недели: ");
int x = Convert.ToInt32(Console.ReadLine());
if (x < 1 | x > 7 )
{
    Console.WriteLine("Нет такого дня недели");
}
else
{
    if (x == 1) Console.WriteLine("Это же Понедельник!");
    if (x == 2) Console.WriteLine("Это же Вторник!");
    if (x == 3) Console.WriteLine("Это же Среда!");
    if (x == 4) Console.WriteLine("Это же Четверг!");
    if (x == 5) Console.WriteLine("Это же Пятница!");
    if (x == 6) Console.WriteLine("Это же Суббота!");
    if (x == 7) Console.WriteLine("Это же Воскресенье!");
}