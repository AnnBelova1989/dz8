//Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
int InputNum(string messsage)
{
    System.Console.WriteLine(messsage);
    return int.Parse(Console.ReadLine());
}
int[,] CreateArray1(int rows, int columns)
{
    return new int[rows, columns];
}
int[,] CreateArray2(int rows, int columns)
{
    return new int[rows, columns];
}
void FillArray(int[,] array, int minValue, int maxValue)
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
int[,] ArrayMult(int[,] array1, int[,] array2)
{
    int[,] arrMult = new int[array1.GetLength(0), array2.GetLength(1)];

    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            //arrMult[i, j] = 0;
            for (int k = 0; k < array1.GetLength(1); k++)
            {
                arrMult[i, j] += array1[i, k] * array2[k, j];
            }
            // System.Console.Write($"{arrMult[i,j]}\t");
            // System.Console.WriteLine();
        }

    }
return arrMult;
}

int rows1 = InputNum("Введите количество строк 1 массива: ");
int columns1 = InputNum("Введите количество столбцов 1 массива: ");
int rows2 = InputNum("Введите количество строк 2 массива: ");
int columns2 = InputNum("Введите количество столбцов 2 массива: ");
if (rows1 != columns2)

{
    System.Console.WriteLine($"Нельзя найти произведение двух матриц!");
}
else
{
    int[,] myArray1 = CreateArray1(rows1, columns1);
    int[,] myArray2 = CreateArray2(rows2, columns2);

    int min = InputNum("Введите минимальное значение массива: ");
    int max = InputNum("Введите максимальное значение массива: ");

    FillArray(myArray1, min, max);
    FillArray(myArray2, min, max);
    PrintArray(myArray1);
    System.Console.WriteLine();
    PrintArray(myArray2);
    System.Console.WriteLine();
    int[,] mult = ArrayMult(myArray1, myArray2);
    PrintArray(mult);
}