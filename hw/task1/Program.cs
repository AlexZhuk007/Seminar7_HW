// Задача 1: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не использовать циклы.

Console.Clear();

void ShowDigits(int num_max, int num_min)
{
    if (num_max == num_min-1)
    {
        return;
    }

    ShowDigits(num_max-1, num_min);
    Console.Write(num_max+" ");
}

Console.WriteLine("Введите максимальное число: ");
int num_max = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимальное число: ");
int num_min = Convert.ToInt32(Console.ReadLine());

ShowDigits(num_max, num_min);