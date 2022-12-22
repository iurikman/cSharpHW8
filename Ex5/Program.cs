/*
Задача 62. 
Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

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

int[,] GetArray(int m, int n)
{
    int[,] array = new int[m, n];

    int startL = 0;
    int endL = n - 1;

    int startH = 0;
    int endH = m - 1;
    int number = 1;
    while (number <= n * m)
    {

        // идем вправо
        for (int k = startL; k < endL; k++)
        {
            if (number <= m * n)
            {
                array[startL, k] = number;
                number++; 
            }

        }
        // идем вниз
        for (int k = startH; k < endH; k++)
        {
            if (number <= m * n)
            {
                array[k, endL] = number;
                number++;   
            }        
        }
        // идем влево
        for (int k = endL; k >= startL; k--)
        {
            if (number <= m * n)
            {            
                array[endH, k] = number;
                number++;
            }
        }
        // идем вверх
        endH--;
        for (int k = endH; k > startH; k--)
        {
            if (number <= m * n)
            {            
                array[k, startL] = number;
                number++; 
            }          
        }
        startL++;
        endL--;
        startH++;

    }
    return array;
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

int m = GetNumber("Введите m: ");
int n = GetNumber("Введите n: ");
int [,] array = GetArray(m, n);
PrintArray(array);