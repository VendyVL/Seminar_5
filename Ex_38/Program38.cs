// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// Гугл говорит, что вещественные числа, это тупо любые.

float[] arr = new float[5];// ограничим это безобразие

float[] PrintArray(float[] array) // копипаста
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next();
        Console.Write(array[i] + " ");
    }
    return array;
}
Console.Write("[ ");
PrintArray(arr);
Console.Write("]");
Console.WriteLine();

float max = 0;
float min = 0;

for (int i = 0; i<arr.Length; i++)
{
    if (arr[i]>max) max = arr[i];
    if (arr[i]<min) min = arr[i];
}

float res = max-min;
Console.Write($"Разница между максимальным и минимальным элементов массива = {res}");