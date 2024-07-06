//Задача 1: Задайте значения M и N.
//Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
//Использовать рекурсию, не использовать циклы.

void MToN(int N, int M)
{
    if (N > M-1)
    {
        MToN(N-1, M);
        Console.Write (N + " ");
    }
}
void NToM(int N, int M)
{
    if (N < M+1)
    {
        NToM(N+1, M);
        Console.Write (N + " ");
    }
}
// Проверка работоспособности рекурсивных функций (без введения чисел от пользователя):
// NToM(5, 10);
// Console.WriteLine(' ');
// MToN(6, 3);

System.Console.WriteLine("Введите M: " );
int M = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите N: ");
int N = Convert.ToInt32(Console.ReadLine());

if (M > N) // Проверка условий вызова рекурсивных функций после введения различных чисел от пользователя
{
    NToM(N, M);
}
else
{
    MToN(N, M);
}