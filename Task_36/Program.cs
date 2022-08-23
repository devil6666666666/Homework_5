// Задайте одномерный массив, заполненный случайными
// числами. Найдите сумму элементов, стоящих на нечётных позициях.

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

int[] array = FillArray(10, -20, 20);
Console.WriteLine('[' + string.Join(", ", array) + ']');

int j = 0;
int i = 1;
for (i = 1; i < array.Length; i += 2)
{
    j = j + array[i];
}
Console.WriteLine($"Сумма элементов, стоящих в массиве на нечётных позициях, равна {j} ");