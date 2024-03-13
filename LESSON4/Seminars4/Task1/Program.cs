// Задайте двумерный массив. найдите элементы, у которых оба индекса чётные
// и замените эти элементы на их квадраты.

void PrintArr(int[,] arry)
{
    for (int i = 0; i < arry.GetLength(0); i++)
    {
        for (int j = 0; j < arry.GetLength(1); j++)
        {
            Console.Write($"{arry[i, j]}\t");
        }
        Console.WriteLine();
    }
}

int[,] Squartes(int[,] arry)
{
    for (int i = 0; i < arry.GetLength(0); i++)
    {
        for (int j = 0; j < arry.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                arry[i, j] = arry[i, j] * arry[i, j];
            }
        }
    }
    return arry;
} 

Console.Write($"Введите размерность m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write($"Введите размерность n: ");
int n = Convert.ToInt32(Console.ReadLine());

int [,] arr = new int [m, n]; // Количество запятых зависит мерность массива (без запятой одномерный, 1 запятая двумерный, 2 запятые трёхмерный)

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = new Random().Next(1,10);
    }
}
PrintArr(arr);

int[,] arr_new = Squartes(arr);
Console.WriteLine();
PrintArr(arr_new);