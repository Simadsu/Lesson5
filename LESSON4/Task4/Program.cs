// break - прерывает выполнение ближайшего внешнего цикла( while, for, foreach)
// Часто используется когда возникло условие, при котором цикл нужно немедленно прервать
// распространенный случай - остановка цикла с условием trut(бесконечный цикл)
// пример

// while (true)
// {
//     Console.WriteLine("i am in loop!");
//     break;
// }

// Пример 2

// Console.WriteLine("Start");

// int[] numbers = {2, 4, 6, 7, 8, 10};
// foreach (int number in numbers)
// {
//     if (number % 2 == 1)
//     {
//         Console.WriteLine("There is odd number")
//         break;
//     }
// }

// Console.WriteLine("Stop");

// Пример 3

// int[,] table = { {1, 1, 1},
//                  {2, -2, 2},
//                  {3, 3, -3} };

// for (int i = 0; i < table.GetLength(0); i++)
// {
//     for (int j = 0; j < table.GetLength(1); j++)
//     {
//         if (table[i, j] < 0)
//         {
//             Console.WriteLine($"There are negative elements in line {i}");
//             break;
//         }
//     }
// }

// Не рекомендуется использовать break, если
// это усложняет логику работы цикла / break можно заменить условием цикла

// Операторы передачи управления continue
// continue - начинает новую итерацию ближайшего внешнего цикла (while, for, foreach)
// часто используется, когда возникло условие, при котором оставшиеся инструкции тела цикла нужно пропустить

// Пример

// for (int i = 1; i <= 5; i++)
// {
//     Console.Write($"Iteration {i}: ");
//     if (i == 3)
//     {
//         Console.WriteLine("Skip");
//         continue;
//     }
//     Console.WriteLine("Some processing");
// }

// Сторонний пример

// void ShowMatrix(int[,] matrix)
// {
//     for (int i = 0; i < matrix.GetLength(0); i++)
//     {
//         for (int j = 0; j < matrix.GetLength(1); j++)
//         {
//             Console.Write($"{matrix[i, j]} ");
//         }
//         Console.WriteLine();
//     }
// }

// Итоги:
// Двумерный массив обладает всеми характеристиками одномерного
// Двумерные массивы применяются в математике, представлении изображений, разработке игр
// Для представления строк в языке C# используется тип данных String
// String является неизменяемым типом, представляет набор методов для обработки строк
// При разработке циклов можно использовать операторы break, continue