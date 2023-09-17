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
    Random random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = random.Next(minValue, maxValue + 1);
    }
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

void SortArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int p = 0; p < array.GetLength(1) - 1; p++)
            {
                if (array[i, p] < array[i, p + 1])
                {
                    (array[i, p], array[i, p + 1]) = (array[i, p + 1], array[i, p]);
                }
            }
        }
    }
}

int rows = InputNum("Введите количество строк: ");
int columns = InputNum("Введите количество столбцов: ");
int[,] myArray = Create2DArray(rows, columns);
int min = InputNum("Введите минимальное значение массива: ");
int max = InputNum("Введите максимальное значение массива: ");
Fill2DArray(myArray, min, max);
PrintArray(myArray);
SortArray(myArray);
System.Console.WriteLine("Отсортированный массив: ");
PrintArray(myArray);
