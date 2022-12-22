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
    int[,] array = new int[m,n];
    int i = 0;
    int j = 0;
    int count = 0;
    for (int k = 0; k < m*n; k++)
    {
        if (array[i,j+1] == 0)
        {
            j++;
        } else if (i < n - j) 
        {
            i++;
        }
        else if (j =)
        {
            i--;
        }
        else if ()
        {
            j--;
        }
        array[i, j] = count + 1;
    }
}

