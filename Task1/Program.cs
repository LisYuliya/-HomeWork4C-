/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/


//Вариант 1. Решение без цикла

System.Console.WriteLine("Вариант 1. Решение без цикла");

System.Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine()!);

System.Console.WriteLine("Введите степень числа");
int exponent = Convert.ToInt32(Console.ReadLine()!);

System.Console.WriteLine($"Ответ: {num}^{exponent} = {Math.Pow(num, exponent)}");



//Вариант 2. Решение через цикл
int Exponent(int numA, int numB)
{
    int result = 1;
    for (int i = 1; i <= numB; i++)
    {
        result = result * numA;

    }
    return result;
}

System.Console.WriteLine("Вариант 2. Решение через цикл");

Console.Write("Введите число: ");
int numA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите степень числа: ");
int numB = Convert.ToInt32(Console.ReadLine());

int exponent1 = Exponent(numA, numB);

Console.WriteLine($"Ответ: {numA}^{numB} = " + exponent1);