// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
 
System.Console.WriteLine("Задайте длину массива:");
int size = int.Parse(System.Console.ReadLine());
int[] array = ArrayRandom(size);
System.Console.WriteLine("Число четных чисел в масcиве = " + evenInteger(array));
 
int[] ArrayRandom(int len)
{
    int[] arr = new int[len];
    Random rand = new Random();
    for (int i = 0; i < len; i++)
    {
        arr[i] = rand.Next(100, 1000);
    }
    System.Console.WriteLine($"[{string.Join(" | ", arr)}]");
    return arr;
}
 
int evenInteger(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) count++;
    }
    return count;
}