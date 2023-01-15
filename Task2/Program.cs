// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNumbers(int begin, int end)
{
    if (begin == end) return begin;
    return (begin + SumNumbers(begin + 1, end));
}
int EnterData(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}
int M = EnterData("Введите 1 число: ");
int N = EnterData("Введите 2 число: ");
Console.WriteLine(SumNumbers(M, N));