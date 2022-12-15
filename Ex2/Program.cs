/*
Задача 56: 
Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить 
строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7

Программа считает сумму элементов в каждой 
строке и выдаёт номер строки с наименьшей 
суммой элементов: 1 строка
*/

// 1.функция получения числа
// 2.функция получения положительного числа
// 3.функция получения двумерного массива
// 4.функция определения строки с наименьшей суммой элементов
// 5.функция печати массива

// 1.функция получения числа
int GetNumber(string message)
{
    Console.WriteLine(message);
    int result = 0;
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число");
        }
    }
    return result;
}

// 2.функция получения положительного числа
int GetPositiveNumber(string message)
{
    Console.WriteLine(message);
    int result = 0;
    while (true)
    {
        if (int.TryParse(Console.ReadLine(), out result) && result > 0)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число");
        }
    }
    return result;
}

// 3.функция получения двумерного массива
int[,] GetRandomArray(int m, int n, int minValue, int maxValue)
{
    int [,] array = new int [m, n];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = rnd.Next(minValue, maxValue + 1);
        }
    }
    return array;
}

// 4.функция определения строки с наименьшей суммой элементов
(int, int[]) MinStringSumm(int[,] array)
{
    int[] summOfEachString = new int [array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            summOfEachString[i] += array[i,j];
        }
    }

    int minStringSumm = 0;
    for (int i = 1; i < summOfEachString.Length; i++)
    {
        if (summOfEachString[i] < summOfEachString[i-1])
        {
            minStringSumm = i+1;
        }
    }

    return (minStringSumm , summOfEachString);
}

// 5.функция печати массива
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

int m = GetPositiveNumber("Введите m: ");
int n = GetPositiveNumber("Введите n: ");
int minValue = GetNumber("Введите minValue: ");
int maxValue = GetNumber("Введите maxValue: ");
int[,] array = GetRandomArray(m, n, minValue, maxValue);
Console.WriteLine();

Console.WriteLine("Исходный массив:");
PrintArray(array); 
int minStringSumm = MinStringSumm(array).Item1;
Console.WriteLine();
Console.WriteLine($"Строка {minStringSumm} имеет наименьшую сумму.");
Console.WriteLine();