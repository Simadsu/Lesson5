// ЗАДАЧА 
// КАК ВЫВОДИТЬ СТРОКИ СИМВОЛОВ

// string CharOfString(char[] arr)
// {
//     string st = "";
//     foreach (char item in arr)
//     {
//         st += item;
//     }
//     return st;
// }

// char[] chars = new char[] {'a', 'b', 'c', 'd'};

// Console.WriteLine(chars[0]);
// Console.WriteLine(CharOfString(chars));


// ЗАДАЧА
// На основе символо строки (тип  String) сформировать массив символов (тип char[])
// Вывести массив на экран.

// Console.WriteLine("Напиши сообщение");
// string input = Console.ReadLine()!;

// char[] charMas = new char[input.Length];

// for (int i = 0; i < input.Length; i++)
// {
//     charMas[i] = input[i];
//     Console.Write(charMas[i]);
// }

// ЛИБО ЕСЛИ ОХОТА ЗАМОРОЧИтСЯ КОД НИЖЕ

// string input = Console.ReadLine()!;

// char[] MassChar(string st)
// {
//     char[] Mass_char = new char[st.Length];

//     for (int i = 0; i < st.Length; i++)
//     {
//         Mass_char[i] = st[i];

//     }
//     return Mass_char;
// }

// void PrintChar(char[] Mass_char)
// {
//     foreach (char i in Mass_char)
//     {
//         Console.WriteLine(i);
//     }
// }

// char[] mass_char_new = MassChar(input);
// PrintChar(mass_char_new);

// ЗАДАЧА
// Считать строку с консоли, состоящую из латинских букв в нижнем регистре.
// Выяснить, сколько среди введенных букв гласных (aouei).

// int CountVowels(string st)
// {
//     int count = 0;
//     string vowels = "aoueiAOUEI";
//     for (int i = 0; i < st.Length; i++)
//     {
//         foreach (var j in vowels)
//         {
//             if (st[i] == j)
//             count++;
//         }
//         // if (st[i] == 'a' || st[i] == 'e' || st[i] == 'o' || st[i] == 'u' || st[i] == 'i' ||
//         // st[i] == 'A' || st[i] == 'E' || st[i] == 'O' || st[i] == 'U' || st[i] == 'I')
//         // {
//         //     count++;
//         // }
//     }
//     return count;
// }

// bool CheckIfLetter(string st)
// {
//    for (int i = 0; i < st.Length; i++)
//     {
//         if (!(char.IsLetter(st[i]) || st[i] == ' '))
//         {
//             return false;
//         }
//     }
//     return true;
// }

// Console.WriteLine("Напиши сообщение");
// string st = Console.ReadLine()!;
// if(CheckIfLetter(st))
// {
// int vowels = CountVowels(st);
// Console.WriteLine(vowels);
// }
// else Console.WriteLine("Введен неверный формат");



// ДОМАШНИЕ ЗАДАЧИ 
//Задача 1
// Задайте двумерный массив символов (тип char[,]). Создать строку из символов этого массива.
// a b c
// d e f ==> abcdef

// char[] alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToCharArray(); // Запись одномерного массива
// Console.WriteLine(alpha[0]);

// string[,] Tablero = new string[3, 3] {{"a","b","c"},
//                                       {"d","e","f"},
//                                       {"g","h","i"} }; // Запись двуменого массива


        // char[,] charArray = new char[,]
        // {
        //     { 'H', 'e', 'l', 'l', 'o' },
        //     { 'W', 'o', 'r', 'l', 'd' }
        // };

        // string result = ""; // создаем пустую строку в которую будем заполнять символами выше

        // for (int i = 0; i < charArray.GetLength(0); i++)
        // {
        //     for (int j = 0; j < charArray.GetLength(1); j++)
        //     {
        //         result += charArray[i, j];
        //     }
        // }

        // Console.WriteLine("Результат: " + result);


//Задача 2 
// Задайте строку, содержащую латинские буквы в обоих регистрах. Сформируйте строку, в которой все заглавные буквы заменены на строчные.
// AbCD1ef = abcd1ef.

//     Console.WriteLine("Напиши сообщение");
// string st = Console.ReadLine()!;
//     Console.WriteLine(st.ToLower());

// Console.WriteLine("11QqQq".ToLower()); // Выведет 11qqqq.

//Задача 3
// Задайте произвольную строку. Выясните, является ли она палиндромом. шалаш - да, 55655 - да, aBcD1eC - нет.

// Console.Write("Введите строку: ");
//         {
//         string input = Console.ReadLine();

//         if (CheckIfPalindrome(input))
//         {
//             Console.WriteLine("Введенная строка является палиндромом.");
//         }
//         else
//         {
//             Console.WriteLine("Введенная строка не является палиндромом.");
//         }
//     }

//     static bool CheckIfPalindrome(string st)
//     {
//         st = st.ToLower(); // Приводим все символы строку к нижнему регистру

//         int i = 0;
//         int j = st.Length - 1;

//         while (i < j)
//         {
//             if (!char.IsLetterOrDigit(st[i]))
//             {
//                 i++;
//             }
//             else if (!char.IsLetterOrDigit(st[j]))
//             {
//                 j--;
//             }
//             else if (st[i] != st[j]) // условие что значения не равны между собой, то false
//             {
//                 return false;
//             }
//             else
//             {
//                 i++;
//                 j--;
//             }
//         }

//         return true;
//     }
