// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
 
// рандом выбрал от 1 до 10 для наглядности
 
System.Console.WriteLine("Задайте длину массива:");
int size = int.Parse(System.Console.ReadLine());
int[] array = ArrayRandom(size);
System.Console.WriteLine(SumOddNumber(array));


 
int[] ArrayRandom(int len)
{
    int[] arr = new int[len];
    Random rand = new Random();
    for (int i = 0; i < size; i++)
    {
        arr[i] = rand.Next(1, 11);
    }
    System.Console.WriteLine($"[{string.Join(" | ", arr)}]");
    return arr;
}
 
int SumOddNumber(int[] arr)
{
    int sum = 0;
    for (int i = 1; i < arr.Length; i += 2)
    {
        sum += arr[i];
    }
    return sum;
}