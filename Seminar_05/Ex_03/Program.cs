//Напишите программу, которая определяет, присутствует ли заданное число.

bool SearchElement(int[] array, int value)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] == value)
        {
            return true;
        }
    }
    return false;
}

int[] array = new int[4] {-4, -8, 8, 3};
int number;

Console.WriteLine("Введите число: ");
number = Convert.ToInt32(Console.ReadLine());

Console.Write(SearchElement(array, number));