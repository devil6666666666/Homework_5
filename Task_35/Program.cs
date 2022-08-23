// Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения
// которых лежат в отрезке [10, 99].

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

int[] array = FillArray(123, -50, 200);
Console.WriteLine('[' + string.Join(", ", array) + ']');

int j = 0;
int i = 0;
for (i = 0; i < array.Length; i++)
{
    if (array[i] >= 10 && array[i] <= 99)
    {
        j++;
    }
}
Console.WriteLine("Количество элементов массива, значения ");
Console.WriteLine($"которых лежат в отрезке [10, 99], равно {j}");