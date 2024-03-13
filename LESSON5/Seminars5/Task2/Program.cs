// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от 1 до N.

// Вариант 1

// void Strochka(int n)
// {
//     if (n < 1) return;
//     Strochka(n - 1);
//     Console.Write(n + " ");
// }
// Console.WriteLine("Введите число равное N:");
// int n = Convert.ToInt32(Console.ReadLine());
// Strochka(n);

// Вариант 2

Console.WriteLine("Введите стартовое число равное M:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите конечное число равное N:");
int n = Convert.ToInt32(Console.ReadLine());

string Strochka(int n, int m)
{
    if (m == n) return Convert.ToString(n);
    return m + ", "+ Strochka(n, m + 1) ;
}
Console.WriteLine(Strochka(n, m));

// Вариант 3

// void Strochka(int n)
// {
//     if (n < 1) return;
//     Strochka(n - 1);
//     Console.Write($"{n} ");
// }
// Console.WriteLine("Введите число равное M:");
// int m = Convert.ToInt32(Console.ReadLine());
// Strochka(m);