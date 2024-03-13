// Создать двумерный массив с размерами 3х5, состоящий из целых чисел
// вывести его элементы на экран.

// int[,] matrix = new int[3, 5];

// Random rnd = new();
// for (int i = 0; i < matrix.GetLength(0); i++) // обращаемся к строкам одномерного массива
// {
//     for (int j = 0; j < matrix.GetLength(1); j++) // обращаемся к элементам одномерного массива
//     {
//         matrix[i, j] = rnd.Next(1, 11);
//     }
// }

// for (int i = 0; i < matrix.GetLength(0); i++) // обращаемся к строкам одномерного массива
// {
//     for (int j = 0; j < matrix.GetLength(1); j++) // обращаемся к элементам одномерного массива
//     {
//         Console.Write($"{matrix[i, j]} "); // такой тип Вывода данных - интерполяция строк

//     }
//     Console.WriteLine();
// }

int[,] CreateMatrix(int rowCount, int colomsCount)
{
    int[,] matrix = new int[rowCount, colomsCount];

    Random rnd = new();
    for (int i = 0; i < matrix.GetLength(0); i++) // обращаемся к строкам одномерного массива
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // обращаемся к элементам одномерного массива
        {
            matrix[i, j] = rnd.Next(1, 11);
        }
    }
    return matrix;
}

void ShowMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++) // обращаемся к строкам одномерного массива
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // обращаемся к элементам одномерного массива
        {
            Console.Write($"{matrix[i, j]} "); // такой тип Вывода данных - интерполяция строк

        }
        Console.WriteLine();
    }
}

int[,] matrix = CreateMatrix(4, 5);
ShowMatrix(matrix);