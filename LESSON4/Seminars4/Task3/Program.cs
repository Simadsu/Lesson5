// Задайте двумерный массив из целых чисел. Сформируйте новый одномерный массив, 
// состоящий из средних арифметических значений по строкам двумерного массива.
// Пример:
// [2 3 4 3] => 3
// [4 3 4 1] => 3 => [3 3 5]
// [2 9 5 4] => 5

int[,] Random_mas(int m, int n)  // массив случайных чисел на заполнение полученного массива из нулей
{
    int[,] arr = new int[m, n];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i, j] = new Random().Next(1, 10);
        }
    }
    return arr;
}

void Print_mas(int[,] arr) // функция для печати двумерного массива
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]}\t"); // табуляция нужна для более удобного вывода значения, но это НЕОБЯЗАТЕЛЬНО, можно оставить просто пробел
        }
        Console.WriteLine();
    }
}

double[] Average(int[,] arr) // функция для среднего значения по строкам двумерного массива
{
    double[] mas_one = new double[arr.GetLength(0)];
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        double count = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            count += arr[i,j]; // подсчитываем сумму всех элементов массива
        }
        mas_one[i] = count / arr.GetLength(1);  // находим среднее арифметическое значений по строкам массива
    }
    return mas_one;
}

void Print_mas_one(double[] mass) // функция для печати одномерного массива
{
    foreach (var item in mass)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}

Console.Write($"Введите размерность m: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write($"Введите размерность n: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] arr = Random_mas(m, n);
Print_mas(arr);
double[] mas_one = Average(arr);
Print_mas_one(mas_one);