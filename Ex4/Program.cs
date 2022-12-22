/*
Задача 60.
Сформируйте трёхмерный массив из неповторяющихся 
двузначных чисел. 
Напишите программу, которая будет построчно 
выводить массив, добавляя индексы каждого элемента.

Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
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

//функция получения массива
int[,,] GetArray(int m, int n, int k)
{
    int[,,] array = new int[m, n, k];
    Random rnd = new Random((int)DateTime.Now.Ticks);
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int l = 0; l < k; l++)
            {
                array[i,j,l] = rnd.Next(100, 1000);
            }
        }
    }
    return array;
}

// 3.функция печати массива
void PrintArray(int[,,] array)
{
    for (int k = 0; k < array.GetLength(0); k++)
    {
        for (int i = 0; i < array.GetLength(1); i++)
        {
            for (int j = 0; j < array.GetLength(2); j++)
            {
                Console.Write($"{array[i,j,k]} ({i},{j},{k})  ");
            }
            Console.WriteLine();
        } 
    }
}

int m = GetNumber("Введите m");
int n = GetNumber("Введите n");
int k = GetNumber("Введите k");
int[,,] array = GetArray(m,n,k);
PrintArray(array);