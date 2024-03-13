// назовем число "интересным" если его сумма цифр чётная
// Создать двумерный массив, состоящий из целых чисел/
// Вывести на экран "интересные" элементы массива.

int[,] CreateMatrix(int rowCount, int colomsCount)
{
    int[,] matrix = new int[rowCount, colomsCount];

    Random rnd = new();
    for (int i = 0; i < matrix.GetLength(0); i++) // обращаемся к строкам одномерного массива
    {
        for (int j = 0; j < matrix.GetLength(1); j++) // обращаемся к элементам одномерного массива
        {
            matrix[i, j] = rnd.Next(1, 1000);
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

int[,] matrix = CreateMatrix(3, 4);
ShowMatrix(matrix);
foreach (int e in matrix)
{
    if(IsInteresting(e) == true)
    {
        Console.WriteLine(e);
    }
}

bool IsInteresting(int value)
{
    int sumOfDigits = GetSumOfDigits(value);
    if(sumOfDigits % 2 == 0)
    {
        return true;
    }
    return false;
}

int GetSumOfDigits(int value)
{
    int sum = 0;
    while(value > 0)
    {
        sum = sum + value % 10;
        value = value / 10;
    }
    return sum;
}