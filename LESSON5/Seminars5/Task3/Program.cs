// Считать строку с консоли, содержащую латинские буквы.
// Вывести на экран согласные буквы этой строки.

// void WriteConsonants(string n)
// {
//     if (n.Length == 0) return;
//     string vowels = "aoueiAOUEI";
//     if (!vowels.Contains(n[0]))
//     {
//         Console.Write(n[0]);
//     }
//     WriteConsonants(n[1..]);
// }
// Console.WriteLine("Введите текст:");
// string n = Console.ReadLine();
// WriteConsonants(n);

// Второй вариант

void WriteConsonants(string n, int i = 0)
{
    if (n.Length == 0) return;
    string vowels = "aoueiAOUEI";
    if (!vowels.Contains(n[i]))
    {
        Console.Write(n[i]);
    }
    WriteConsonants(n.Substring(i+1,n.Length-1));
}

Console.WriteLine("Введите текст:");
string n = Console.ReadLine()!;
WriteConsonants(n);