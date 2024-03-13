// Задайте двумерный массив. найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0), (1,1) и т.д.)
// пример 
// [2] 3  4  3
//  4 [3] 4  1  => 2 + 3 + 5 = 10
//  2  9 [5] 4

void PrintArr(int[,] arry)
{
    for (int i = 0; i < arry.GetLength(0); i++)
    {
        for (int j = 0; j < arry.GetLength(1); j++)
        {
            Console.Write($"{arry[i, j]}\t"); // табуляция нужна для более удобного вывода значения, но это НЕОБЯЗАТЕЛЬНО, можно оставить просто пробел
        }
        Console.WriteLine();
    }
}

int SummMainLine(int[,] arry)
{
    int s = 0;
    for (int i = 0; i < arry.GetLength(0); i++)
    {
        for (int j = 0; j < arry.GetLength(1); j++)
        {
            if (i == j)
            {
                s = s + arry[i, j];
            }
        }
    }
    return s;
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

int s = SummMainLine(arr);
Console.WriteLine();
Console.WriteLine($"Сумма равна {s} ");