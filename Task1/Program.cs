// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

string NaturakNumbers(int begin, int end)
{
    if (begin == end) return begin.ToString();
    return (begin + " " + NaturakNumbers(begin + 1, end));
}
int EnterData(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}
int N = EnterData("Введите 1 число: ");
int M = EnterData("Введите 2 число: ");
Console.WriteLine(NaturakNumbers(N, M));