// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

System.Console.WriteLine("Задайте длину массива:");
int size = int.Parse(System.Console.ReadLine());
double[] array = arrayRandom(size);
System.Console.WriteLine("Разница между максимальным и минимальным элементом массива = " + Math.Round(differenceMaxMin(array), 3));


double[] arrayRandom(int len)
{
    double[] arr = new double[len];
    Random rand = new Random();
    for (int i = 0; i < len; i++)
    {
        arr[i] = Math.Round(rand.Next(1, 100) + rand.NextDouble(), 3);
    }
    System.Console.WriteLine($"[{string.Join(" | ", arr)}]");
    return arr;
}

double differenceMaxMin(double[] arr)
{
    double min = arr[0];
    double max = arr[0];
    for (int i = 1; i < arr.Length; i++)
    {
        if (arr[i] > max) max = arr[i];
        else if (arr[i] < min) min = arr[i];
    }
    System.Console.WriteLine($"Максимальное значение массива {max} \nМинимальное значение массива {min}");
    double difference = max - min;
    return difference;
}