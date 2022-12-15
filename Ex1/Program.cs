/*
Задача 54: 
Задайте двумерный массив. 
Напишите программу, которая упорядочит по убыванию 
элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

// 1.функция получения числа
// 2.функция получения положительного числа
// 3.функция получения двумерного массива
// 4.функция сортировки строк массива
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
            array[i,j] = rnd.Next(minValue, maxValue);
        }
    }
    return array;
}

// 4.функция сортировки строк массива
void SortArrayStrings(int[,] array)
{
    int temp = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int iterationCount = 0; iterationCount < array.GetLength(0); iterationCount++)
        {
            for (int j = 0; j < array.GetLength(0) - 1; j++)
            {
                if (array[i, j] < array [i, j+1])
                {
                    temp = array[i, j];
                    array[i, j] = array[i, j+1];
                    array[i, j+1] = temp;
                }
                temp = 0;
            }
        }
    }
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
SortArrayStrings(array);
Console.WriteLine();
Console.WriteLine("Отсортированный массив:");
PrintArray(array);
