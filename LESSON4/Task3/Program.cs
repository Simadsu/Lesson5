// string s1 = "hello";

// char[] ch_array = {'w', 'o', 'r', 'l', 'd'};
// string s2 = new String(ch_array);

// string s3 = new String('a', 6); // Результатом будет строка "aaaaaa"

// Считать с консоли строку, состоящую из цифр и латинских букв.
// Сформировать новую строку, состоящую из букв исходной строки.

string GetLettersFromstring(string s)
{
    string letters = "";
    foreach (char e in s)
    {
        if (char.IsAsciiLetter(e) == true)
        {
            letters = letters + e;
        }
    }
    return letters;
}

string str = Console.ReadLine();
string result = GetLettersFromstring(str);
Console.WriteLine(result);