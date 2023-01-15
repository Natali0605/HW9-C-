// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int FunctionAkkermana(int m, int n)
{
    if(m == 0) return n + 1;
    if(m > 0 & n == 0) return FunctionAkkermana(m-1,1);
    else return FunctionAkkermana(m-1,FunctionAkkermana(m,n-1));
}
int EnterData(string text)
{
    Console.Write(text);
    int number = int.Parse(Console.ReadLine());
    return number;
}
int M = EnterData("Введите 1 число: ");
int N = EnterData("Введите 2 число: ");
Console.WriteLine(FunctionAkkermana(M, N));