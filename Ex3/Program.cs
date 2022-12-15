/*
Задача 58: 
Задайте две матрицы. 
Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/

// 1.функция получения числа
// 2.функция получения положительного числа
// 3.функция получения двумерного массива
// 4.функция нахождения произведения двух матриц
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
int[,] GetRandomArray(int m, int minValue, int maxValue)
{
    int [,] array = new int [m, m];
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

// 4.функция нахождения произведения двух матриц
int[,] ProductOfMatrix(int[,] firstArray, int[,] secondArray)
{
    int[,] result = new int[firstArray.GetLength(0), secondArray.GetLength(1)];
    
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            int subProduct = 0;
            for (int k = 0; k < firstArray.GetLength(0); k++)
            {
                for (int l = 0; l < firstArray.GetLength(1); l++)
                {
                    if (k == l)
                    {
                        subProduct += firstArray[k,l] * secondArray[l,k];
                    }
                }
            }
            result[i, j] = subProduct;
            subProduct = 0;
        }
    }

    return result;
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
int minValue = GetNumber("Введите minValue: ");
int maxValue = GetNumber("Введите maxValue: ");
int[,] firstArray = GetRandomArray(m, minValue, maxValue);
Console.WriteLine();
int[,] secondArray = GetRandomArray(m, minValue, maxValue);
Console.WriteLine();

Console.WriteLine("Матрица 1: ");
PrintArray(firstArray); 
Console.WriteLine("Матрица 2: ");
PrintArray(secondArray); 
int[,] productOfMatrix = ProductOfMatrix(firstArray, secondArray);
Console.WriteLine();
PrintArray(productOfMatrix); 
