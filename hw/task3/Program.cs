// Задача 3: Задайте произвольный массив. Выведете
// его элементы, начиная с конца. Использовать
// рекурсию, не использовать циклы.

Console.Clear();

int[] CreateRandomArray(int min, int max, int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}
void ShowArray(int[] array)
{
    foreach (int item in array)
    {
        Console.Write($"{item} ");
    }
}

void ShowArraySymbols(int[] array, int index)
{
    if (index < 0)
    {
        return;
    }

    Console.Write(array [index] + " ");
    ShowArraySymbols(array, index-1);
    
}



Console.WriteLine("Введите минимальное значение");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимальное значение");
int max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());

int[] array = CreateRandomArray(min, max, size);
ShowArray(array);

Console.WriteLine();

ShowArraySymbols(array, array.Length-1);