// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


Console.WriteLine("Ведите размер массива");
int num = Convert.ToInt32(Console.ReadLine());

int[] arr = new int[num];// В условии это не требуется, но и постоянная длинна не задана

int[] PrintArray(int[] array) // из предыдущей задачи
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
        Console.Write(array[i] + " ");
    }
    return array;
}

PrintArray(arr);
Console.WriteLine();
int count=0;


for (int i = 0; i < arr.Length;i++)
{
    if ((arr[i] % 2) == 0)
    {
        count++;
    }

}
Console.WriteLine($"Количество чётных чисел в массиве = {count}");