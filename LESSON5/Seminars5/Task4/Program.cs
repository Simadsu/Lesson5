// Задача 1.
// Задайте значения M и N. Напишите программу, которая выведет все натуральные числа
// в промежутке от M до N. Использовать рекурсию, не использовать циклы.


// Console.WriteLine("Введите стартовое число равное M:");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите конечное число равное N:");
// int n = Convert.ToInt32(Console.ReadLine());

// string Strochka(int n, int m)
// {
//     if (m == n) return Convert.ToString(n);
//     return m + ", "+ Strochka(n, m + 1) ;
// }
// Console.WriteLine(Strochka(n, m));


// Задача 2.
// Напитие программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.


// Console.WriteLine("Введите первое неотрицательное число равное M:");
// int m = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе неотрицательное число равное N:");
// int n = Convert.ToInt32(Console.ReadLine());

// int Akkerman(int n, int m) 
// {
//     if (n > 0 && m == 0)
//     {
//         return Akkerman(n - 1, 1);
//     }
//     else if (n == 0 && m >= 0)
//     {
//         return m + 1;
//     }
//     else return Akkerman(n - 1, Akkerman(n, m - 1));

// }
// Console.Write(Akkerman(n, m));


// Задача 3.
// Задайте произвольный массив. Выведете его элементы, начиная с конца.
// Использовать рекурсию, не использовать циклы.

static void ReverseArray(int[] mas, int start, int end)
{
    if (start >= end)
    {
        return;
    }

    int temp = mas[start];
    mas[start] = mas[end];
    mas[end] = temp;

    ReverseArray(mas, start + 1, end - 1);
}

static int[] Random_mas(int[] mas)
{
    for (int i = 0; i < mas.Length; i++)
    {
        mas[i] = new Random().Next(0, 50);
    }
    return mas;
}

static void Print_mas(int[] col)
{
    foreach (var item in col)
    {
        Console.Write($"{item} ");
    }
    Console.WriteLine();
}

Console.WriteLine("Введите размерность массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[] mas = Random_mas(new int[n]);
Print_mas(mas);
ReverseArray(mas, 0, mas.Length - 1);
Print_mas(mas);