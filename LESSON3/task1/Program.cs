// int Square(int value)
// {
//     int result = value * value;
//     return result;
// }

// int Multiply(int value1, int value2)
// {
//     int result = value1 * value2;
//     return result;
// }

// // Если функция ничего не возвращает

// void ShowSquare(int value)                // Определение функции
// {
//     int result = value * value; // Тело   // Определение функции
//     Console.Write(result);      // Тело   // Определение функции
// }

// // Функции делятся на 4 группы:

// void ShowHelloMessage()   // Без параметров и без возвращаемого значения
// {
//     Console.WriteLine("Hello World!");
// }

// double GetPi()       // Без параметров с возвращаемым значением
// {
//     return 3.14159;
// }

// void ShowHelloMessage(string message)   // С параметрами и без возвращаемого значения
// {
//     Console.WriteLine(message);
// }

// int AddValues(int a, int b)   // С параметрами и c возвращаемым значением
// {
//     int result = a + b;
//     return result;
// }

double CalculateFormula(int a, int b, int c, int d)
{
    double num = a * b;
    int denum = c + d;
    double result = num / denum;
    return result;
}

double result = CalculateFormula(1, 2, 3, 4);
Console.WriteLine(result);