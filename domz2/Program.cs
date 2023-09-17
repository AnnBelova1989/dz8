//Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
//Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
//Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
using System.Runtime.InteropServices;

int InputNum(string messsage)
{
    System.Console.WriteLine(messsage);
    return int.Parse(Console.ReadLine());
}
int[,] Create2DArray(int rows, int columns)
{
    return new int[rows, columns];
}
void Fill2DArray(int[,] array, int minValue, int maxValue)
{
    //if (array.GetLength(0) != array.GetLength(1))
    //{
    Random random = new Random();
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
                array[i, j] = random.Next(minValue, maxValue + 1);
        }
    //}
    //        else
    //{
    //    System.Console.WriteLine("Матрица не прямоугольная");
    //}
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)

            System.Console.Write($"{array[i, j]}\t");
        System.Console.WriteLine();
    }
}

/*
void PrintListAvr(int[] list)
{
    Console.WriteLine("Сумма элементов строки: ");
    foreach (int el in list)
    {
        Console.Write($"{el}" + "\t");

    }
    Console.WriteLine();
}

int[] FindAverageInColumns(int[,] array)
{
    int sumrows = 0;
    int[] rowsnew = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sumrows = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumrows = sumrows + array[i, j];
        }
        rowsnew[i] = sumrows;
    }
    return rowsnew;
}
*/

int FindAverageInColumns(int[,] array, int i)
{
    int sum = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sum = sum + array[i, j];
    }
    return sum;
}

void MinRows(int arr, int[,] array)
{
    int minsum = 1;
    int sum = FindAverageInColumns(array, 0);
    for (int k = 0; k < array.GetLength(0); k++)
    {
        if (sum > FindAverageInColumns(array, k))
        {
            sum = FindAverageInColumns(array, k);
            minsum = k + 1;
        }
    }
    System.Console.WriteLine($"Минимальная строка {minsum}, значение в строке = {sum}");
}

int rows = InputNum("Введите количество строк: ");
int columns = InputNum("Введите количество столбцов: ");
if (rows==columns)
    {
        System.Console.WriteLine("Массив не прямоугольный");
    }
    else{
int[,] myArray = Create2DArray(rows, columns);
int min = InputNum("Введите минимальное значение массива: ");
int max = InputNum("Введите максимальное значение массива: ");
Fill2DArray(myArray, min, max);
PrintArray(myArray);
System.Console.WriteLine();
int minrows=FindAverageInColumns(myArray,0);
MinRows(minrows, myArray);
    }