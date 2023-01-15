// Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

int Pow(int a, int b)
{
    int result = 1;
    for (int i = 1; i <= b; i++)
    {
        result = result * a;
    }

    return result;
}
Console.WriteLine("Введите число a");
int a = int.Parse(Console.ReadLine());

Console.WriteLine("Введите число b");
int b = int.Parse(Console.ReadLine());
if (b < 1) Console.WriteLine("Число b должно быть больше нуля, введите верное число");
else
    Console.WriteLine($"Число {a} в степени {b} равно {Pow(a, b)}");