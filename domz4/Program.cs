//Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int InputNumbers(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine());
}

int[,,] CreateArray(int razmer1, int razmer2, int razmer3)
{
    return new int[razmer1, razmer2, razmer3];
}

void FillArray(int[,,] array)
{
    
    Random random = new Random();

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if(array[i,j,k]==array[i,j,k])
                array[i, j, k] = random.Next(10,100);
            }
        }
    }
}

void PrintArray(int[,,] array)
{
    
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                System.Console.Write($"{array[i, j, k]}({i}{j}{k})\t");
            }
            System.Console.WriteLine();
        }
    }
}

int x = InputNumbers("Введите X: ");
int y = InputNumbers("Введите Y: ");
int z = InputNumbers("Введите Z: ");
int[,,] myArray = CreateArray(x, y, z);
FillArray(myArray);
PrintArray(myArray);