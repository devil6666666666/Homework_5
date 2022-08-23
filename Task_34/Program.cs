// Задайте массив, заполненный случайными положительными
// трёхзначными числами. Напишите программу,
// которая покажет количество чётных чисел в массиве.

int size = 7;
int leftRange = 100;
int rightRange = 999;
int[] FillArray(int size, int leftRange, int rightRange)
{
    Random rand = new Random();
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(leftRange, rightRange + 1);
    }
    return arr;
}
int[] array = FillArray(size, leftRange, rightRange);
Console.WriteLine('[' + string.Join(", ", array) + ']');
int i = 0;
int j = 0;
for (i = 0; i < size; i++)
{
    if (array[i] % 2 == 0)
    {
        j++;
    }
}
Console.WriteLine($"Количество четных чисел в массиве равно {j}");