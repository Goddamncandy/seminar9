// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.WriteLine("Введите первое неотрицательное число: ");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе неотрицательное число: ");
int M = Convert.ToInt32(Console.ReadLine());

if (N < 0 || M < 0) Console.WriteLine("Введите положительные числа!");

int Akkerman(int N, int M)
{
    if (N == 0) return M + 1;
    if (N != 0 && M == 0) return Akkerman(N - 1, 1);
    if (N > 0 && M > 0) return Akkerman(N - 1, Akkerman(N, M - 1));
    return Akkerman(N, M);
}
Console.WriteLine($"A({N}, {M}) = {Akkerman(M, N)}");