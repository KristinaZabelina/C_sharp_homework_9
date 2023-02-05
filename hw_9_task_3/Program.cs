// Напишите программу вычисления функции Аккермана 
// с помощью рекурсии. Даны два неотрицательных числа m и n.

Console.WriteLine("Введите M");
int M = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите N");
int N = Convert.ToInt32(Console.ReadLine());


int Akkerman(int M, int N)
{
    if (M == 0) return N + 1;
    if (M > 0 && N == 0) return Akkerman(M - 1, 1);
    return Akkerman(M - 1, Akkerman(M, N - 1));
}
Console.WriteLine(Akkerman(M, N));