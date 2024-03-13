// Задача № 1
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение 
// этого элемента или же указание, что такого элемента нет: "Позиция по рядам выходит за пределы массива" или
// "Позиция по колонкам выходит за пределы массива"

// Позиции в массиве считать от единицы. При вводных значениях ответ 6.


using System;

class UserInputToCompileForTest
{
    public static int FindElementByPosition(int[,] array, int x, int y)
    {
        if (!ValidatePosition(array, x, y))
        {
            return -1;
        }

        return array[x - 1, y - 1];
    }

    // Проверка позиций на вхождение в массив
    public static bool ValidatePosition(int[,] array, int x, int y)
    {
        return x >= 1 && x <= array.GetLength(0) && y >= 1 && y <= array.GetLength(1);
    }

    public static void PrintResult(int[,] numbers, int x, int y)
    {
        if (!ValidatePosition(numbers, x, y))
        {
            if (x < 1 || x > numbers.GetLength(0))
            {
                Console.WriteLine("Позиция по рядам выходит за пределы массива");
            }
            else
            {
                Console.WriteLine("Позиция по колонкам выходит за пределы массива");
            }
        }
        else
        {
            int element = FindElementByPosition(numbers, x, y);
            if (element != -1)
            {
                Console.WriteLine($"{element}");
            }
            else
            {
                Console.WriteLine("Такого элемента не существует");
            }
        }
    }
}
class Answer
{
    public static void Main(string[] args)
    {
        int[,] array;

        int x, y;

        if (args.Length >= 3)
        {
            string[] rows = args[0].Split(',');

            int rowCount = rows.Length;
            int colCount = rows[0].Trim().Split(' ').Length;

            array = new int[rowCount, colCount];

            for (int i = 0; i < rowCount; i++)
            {
                string[] rowElements = rows[i].Trim().Split(' ');

                for (int j = 0; j < colCount; j++)
                {
                    if (int.TryParse(rowElements[j], out int result))
                    {
                        array[i, j] = result;
                    }
                    else
                    {
                        Console.WriteLine($"Error parsing element {rowElements[j]} to an integer.");
                        return;
                    }
                }
            }
            if (int.TryParse(args[1], out x) && int.TryParse(args[2], out y))
            {
                UserInputToCompileForTest.PrintResult(array, x, y);
            }
            else
            {
                Console.WriteLine("Error parsing x or y to an integer.");
            }
        }
        else
        {
            array = new int[,]
            {
                {1, 2, 3, 4},
                {5, 6, 7, 8},
                {9, 10, 11, 12}
            };
            x = 2;
            y = 2;

            UserInputToCompileForTest.PrintResult(array, x, y);

        }
    }
}


// Задача № 2 ___________________________________________________________________________________________
// Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива.
// при текущих значениях Выводится:

// 9   10  11  12
// 5   6   7   8
// 1   2   3   4

// using System;

// //Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
// class UserInputToCompileForTest
// {
//     // Печать массива
//     public static void PrintArray(int[,] array)
//     {
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 Console.Write($"{array[i, j]}\t");
//             }
//             Console.WriteLine();
//         }
//     }

//     // Обмен первой с последней строкой
//     public static int[,] SwapFirstLastRows(int[,] array)
//     {
//         int rowCount = array.GetLength(0);
//         int colCount = array.GetLength(1);

//         for (int i = 0; i < colCount; i++)
//         {
//             int temp = array[0, i];
//             array[0, i] = array[rowCount - 1, i];
//             array[rowCount - 1, i] = temp;
//         }

//         return array;
// }

// // Обмен элементами массива
// public static void SwapItems(int[,] array, int i)
// {
//     // int rowCount = array.GetLength(0);

//     // if (i >= 0 && i < rowCount - 1)
//     // {
//     //     int[] temp = new int[array.GetLength(1)];
//     //     for (int j = 0; j < array.GetLength(1); j++)
//     //     {
//     //         temp[j] = array[i, j];
//     //         array[i, j] = array[i + 1, j];
//     //         array[i + 1, j] = temp[j];
//     //     }
//     // }
// }

// public static void PrintResult(int[,] numbers)
// {
//         // Console.WriteLine("Исходная матрица:");
//         // PrintArray(numbers);

//         int[,] swappedArray = SwapFirstLastRows(numbers);

//         // Console.WriteLine("Матрица после обмена первой и последней строк:");
//         PrintArray(swappedArray);
// }
// }
// //Не удаляйте и не меняйте класс Answer!
// class Answer
// {
//     public static void Main(string[] args)
//     {
//         int[,] numbers;

//         if (args.Length >= 1)
//         {
//             // Предполагается, что строки разделены запятой и пробелом, а элементы внутри строк разделены пробелом
//             string[] rows = args[0].Split(',');

//             int rowCount = rows.Length;
//             int colCount = rows[0].Trim().Split(' ').Length;

//             numbers = new int[rowCount, colCount];

//             for (int i = 0; i < rowCount; i++)
//             {
//                 string[] rowElements = rows[i].Trim().Split(' ');

//                 for (int j = 0; j < colCount; j++)
//                 {
//                     if (int.TryParse(rowElements[j], out int result))
//                     {
//                         numbers[i, j] = result;
//                     }
//                     else
//                     {
//                         Console.WriteLine($"Error parsing element {rowElements[j]} to an integer.");
//                         return;
//                     }
//                 }
//             }
//         }
//         else
//         {
//             // Если аргументов на входе нет, используем примерный массив
//             numbers = new int[,]
//             {
//                 {1, 2, 3, 4},
//                 {5, 6, 7, 8},
//                 {9, 10, 11, 12},
//                 {13, 14, 15, 16},
//                 {17, 18, 19, 20}
//             };
//         }
//         UserInputToCompileForTest.PrintResult(numbers);
//     }
// }


// задача №3________________________________________________________________________
// Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// при текущих входящих значениях Выводится: 1

// using System;

// //Тело класса будет написано студентом. Класс обязан иметь статический метод PrintResult()
// class UserInputToCompileForTest
// {
//     /// Вычисление сумм по строкам (на выходе массив с суммами строк)
//     public static int[] SumRows(int[,] array)
//     {
//         int[] sum = new int[array.GetLength(0)];
//         for (int i = 0; i < array.GetLength(0); i++)
//         {
//             int count = 0;
//             for (int j = 0; j < array.GetLength(1); j++)
//             {
//                 count += array[i, j]; // подсчитываем сумму всех элементов массива
//             }
//             sum[i] = count; // записываем сумму в массив
//         }
//         return sum;
//     }

//     // Получение индекса минимального элемента в одномерном массиве
//     public static int MinIndex(int[] array)
//     {
//         int min = array[0];
//         int minIndex = 0;
//         for (int i = 0; i < array.Length; i++)
//         {
//             if (array[i] < min)
//             {
//                 min = array[i];
//                 minIndex = i;
//             }
//         }
//         return minIndex;
//     }
//     public static void PrintResult(int[,] numbers)
//     {
//         int[] sums = SumRows(numbers);
//         int minIndex = MinIndex(sums);

//         Console.WriteLine(minIndex);
//     }
// }

// //Не удаляйте и не меняйте класс Answer!
// class Answer
// {
//     public static void Main(string[] args)
//     {
//         int[,] numbers;

//         if (args.Length >= 1)
//         {
//             // Предполагается, что строки разделены запятой и пробелом, а элементы внутри строк разделены пробелом
//             string[] rows = args[0].Split(',');

//             int rowCount = rows.Length;
//             int colCount = rows[0].Trim().Split(' ').Length;

//             numbers = new int[rowCount, colCount];

//             for (int i = 0; i < rowCount; i++)
//             {
//                 string[] rowElements = rows[i].Trim().Split(' ');

//                 for (int j = 0; j < colCount; j++)
//                 {
//                     if (int.TryParse(rowElements[j], out int result))
//                     {
//                         numbers[i, j] = result;
//                     }
//                     else
//                     {
//                         Console.WriteLine($"Error parsing element {rowElements[j]} to an integer.");
//                         return;
//                     }
//                 }
//             }
//         }
//         else
//         {
//             // Если аргументов на входе нет, используем примерный массив

//             numbers = new int[,] {

//                 {1, 2, 3},
//                 {1, 1, 0},
//                 {7, 8, 2},
//                 {9, 10, 11}

//     };
//         }
//         UserInputToCompileForTest.PrintResult(numbers);
//     }
// }