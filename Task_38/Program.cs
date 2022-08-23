// Задайте с клавиатуры массив вещественных (double) чисел. 
// Найдите разницу между максимальным и минимальным элементами массива.

Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
double[] a = new double[size];
for (int i = 0; i < size; i++)
{
    Console.Write($"Введите {i + 1}-й элемент массива: ");
    a[i] = double.Parse(Console.ReadLine());
}
Console.WriteLine('[' + string.Join("; ", a) + ']');
int j = 0;
double max = a[0];
double min = a[0];
for (j = 1; j < size; j++)
{
    if (a[j] > max)
    {
        max = a[j];
    }
}
for (j = 1; j < size; j++)
{
    if (a[j] < min)
    {
        min = a[j];
    }
}
Console.WriteLine($"Разница между максимальным и минимальным элементами массива равна {max - min}");