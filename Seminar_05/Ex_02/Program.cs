// Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные и наоборот.
// bool Search(int[ sourceArray], int value)
int[] array = new int[8] {4, 3, 7, 5, 9, 1, 6, 0};

for (int i = 0; i < array.Length; i++)
{
    array[i] = array[i] * -1;
    Console.Write(array[i] + " ");
}