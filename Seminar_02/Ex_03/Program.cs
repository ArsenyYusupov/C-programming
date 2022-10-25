//Напишите программу, которая будет принимать на вход два числа и выводить,
// является ли второе число кратным первому. Если число 2 не кратно числу 1,
// то программа выводит остаток от деления.
int numb1, numb2;
string Out;

Console.Write("Ввести первое число: ");
numb1 = int.Parse(Console.ReadLine());

Console.Write("Ввести второе число: ");
numb2 = int.Parse(Console.ReadLine());
int result = numb1 % numb2;

if(result != 0) Out = "не кратно, остаток " + result;
else Out = "кратно";

Console.WriteLine(Out);