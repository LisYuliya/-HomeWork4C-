/*Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
6, 1, 33 -> [6, 1, 33]*/

int[] Array(int n)
{
    int[] array = new int[n];
    for (int i = 0; i < n; i++)
    {
        array[i] = new Random().Next(0, 11);
    }

    string s = string.Join(",", array);
    System.Console.Write(s + " -> ");
    Console.WriteLine("[" + s + "]");

    return array;
}

Console.WriteLine("Введите длину массива: ");
int LengthArray = int.Parse(Console.ReadLine()!);

Array(LengthArray);
