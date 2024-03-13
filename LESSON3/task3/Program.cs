void ZeroEvenElements(int[] arr)
{
    for (int i = 0; i < arr.Length; i++) // поэтому выбор падает на for
    {
        if (arr[i] % 2 == 0)
        {
            arr[i] = 0;
        }
    }

}

void PrintArray(int[] arr)
{
    foreach (int e in arr)  // применяется для перебора элементов
    {
        Console.Write($"{e} ");
    }
}

// foreach неподходит так как нельзя менять значение массива
// while используем когда нет четкого представления о числе операций

int[] array = { 1, 2, 3, 4, 5 };
ZeroEvenElements(array);  // НЕ НУЖНО УКАЗЫВАТЬ ТИП ДАННЫХ int, bool, double и т.д.
PrintArray(array);

// Создание генерации случайных чисел.
// Random rnd = new Random();

// int value = rnd.Next(1, 10); // нижняя и верхняя граница диапазона чисел (верхняя граница не влючается в генерацию)

Random rnd = new Random();

int size = 1000;
int[] arr_int = new int[size];
int i = 0;
while (i < size)
{
    arr_int[i] = rnd.Next(1, 10);
    i++;
}

i = 0;
while (i < size)
{
    Console.Write($"{arr_int[i]} ");
    i++;
}


// правильная запись введения данных в программу

Console.WriteLine("Введите целое число: ")

string input = Console.ReadLine();  // для опознавания текста
int value = Convert.ToInt32(input); // для определения чисел

int size = 10;
int[] arr_int = new int[size];
int i = 0;
while (i < size)
{
    Console.WriteLine("Введите целое число: ")

    string input = Console.ReadLine();  // для опознавания текста
    arr_int[i] = Convert.ToInt32(input); // для определения чисел
    i++;
}